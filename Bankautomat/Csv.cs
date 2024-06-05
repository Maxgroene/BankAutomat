using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Bankautomat
{
    public class Csv
    {
        public List<Customer> Customer = new List<Customer>();
        public List<string> Transaction = new List<string>();

        public string CustomerCSV = @".\Customers.csv";
        public string TransactionCSV = @".\Transaction.csv";

        public Csv()
        {
            // Check if the file exists, if not, create it
            if (!File.Exists(CustomerCSV))
            {
                try
                {
                    using (FileStream fs = File.Create(CustomerCSV)) ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Erstellen der Datei: " + ex.Message);
                }
            }
            if (!File.Exists(TransactionCSV))
            {
                try
                {
                    using (FileStream fs = File.Create(TransactionCSV)) ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Erstellen der Datei: " + ex.Message);
                }
            }
        }
        public void Write(string tempNotiz, string fileName)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true, Encoding.UTF8))
                {
                    writer.WriteLine(tempNotiz);
                }
            }
            catch
            {
                MessageBox.Show("Fehler beim Schreiben: ");
            }
        }

        public void ChangingCustomerMoney(int customerIndex, int money)
        {
            try
            {
                List<string> list = new List<string>();
                using (StreamReader reader = new StreamReader(CustomerCSV, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        list.Add(reader.ReadLine());
                    }
                }
                string[] temp = list[customerIndex].Split(';');
                list[customerIndex] = temp[0] + ";" + temp[1] + ";" + temp[2] + ";" + money;
                ClearCsvFile(CustomerCSV);
                for (int i = 0; i < list.Count; i++)
                {
                    Write(list[i], CustomerCSV);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Schreiben: " + ex.Message);
            }
        }

        public void Read(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName, Encoding.UTF8))
                {
                    switch(fileName)
                    {
                        case ".\\Customers.csv":
                            Customer.Clear();
                            while (!reader.EndOfStream)
                            {
                                string[] data = reader.ReadLine().Split(';');
                                if (data.Length == 4) // Check if the data has exactly 4 fields
                                {
                                    Customer customer = new Customer(data[0], data[1], data[2], Convert.ToInt32(data[3]));
                                    Customer.Add(customer);
                                }
                            }
                            break;

                        case ".\\Transaction.csv":
                            Transaction.Clear();
                            while (!reader.EndOfStream)
                            {
                                Transaction.Add(reader.ReadLine());
                            }
                            break;

                        default:

                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Lesen der CSV-Datei: " + ex.Message);
            }
        }
        public void ClearCsvFile(string fileName)
        {
            try
            {
                // Überschreibe den Inhalt der Datei mit einem leeren String
                File.WriteAllText(fileName, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Löschen des Inhalts der CSV-Datei: " + ex.Message);
            }
        }

        public void AddCustomers()
        {
            Write("Timo;Dummkopf;DE187;845", CustomerCSV);
        }
    }
}
