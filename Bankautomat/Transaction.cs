using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankautomat
{
    public partial class Transaction : Form
    {
        Csv csv = new Csv();
        List<string> customerTransaction = new List<string>();
        public Transaction(int customerIndex)
        {
            InitializeComponent();
            ShowCustomerTransaction(customerIndex);
        }

        private void lbTransaction_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ShowCustomerTransaction(int customerIndex)
        {
            customerTransaction.Clear();

            for (int i = 0; i < customerTransaction.Count; i++) {
                string[] splittedTransaction = csv.Transaction[i].Split(";");

                if (splittedTransaction[0] == Convert.ToString(customerIndex))
                {
                    customerTransaction.Add("Abgebuchter betrag: " + splittedTransaction[1] 
                        + "  Datum: "+ splittedTransaction[2]);
                }
            }
            lbTransaction.DataSource = customerTransaction;
        }
    }
}
