using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankautomat
{
    public partial class LoginPage : Form
    {
        Csv csv = new Csv();
        public LoginPage()
        {
            csv.Read(csv.CustomerCSV);

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbIban.Text) && csv.Customer.Count != 0)
                {

                for (int i = 0; i < csv.Customer.Count; i++)
                {
                    if (csv.Customer[i].Iban == tbIban.Text)
                    {
                        SelectMoney selectMoney = new SelectMoney(i);
                        selectMoney.Show();
                        break;
                        
                    }
                }
            }
        }
    }
}
