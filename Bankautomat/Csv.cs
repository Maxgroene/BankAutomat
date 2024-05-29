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

        string fileName = @".\Customers.csv";

        public Csv()
        {
            // Check if the file exists, if not, create it
            if (!File.Exists(fileName))
            {
                try
                {
                    using (FileStream fs = File.Create(fileName)) ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler beim Erstellen der Datei: " + ex.Message);
                }
            }
        }

        public void Write(string tempNotiz)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileName, true, Encoding.UTF8))
                {
                    writer.WriteLine(tempNotiz);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Schreiben: " + ex.Message);
            }
        }

        public void Read()
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName, Encoding.UTF8))
                {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Lesen der CSV-Datei: " + ex.Message);
            }
        }

        public void AddCustomers()
        {
            Write(";Timo;Dummkopf;DE187;845");
        }
    }
}
