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
    public partial class SelectMoney : Form
    {
        DateTime saveNow = DateTime.Now;
        Csv csv = new Csv();
        private int CustomerIndex;
        public SelectMoney(int customerIndex)
        {
            this.CustomerIndex = customerIndex;

            InitializeComponent();
            csv.Read(csv.CustomerCSV);

            SetTextBox0();
            SetLabels();

        }

        private void btMinus5_Click(object sender, EventArgs e)
        {
            tbNumber5.Text = (Convert.ToInt32(tbNumber5.Text) - 1).ToString();
            CheckIfSmallerNull();
            ChangingLbSum();
        }

        private void btMinus10_Click(object sender, EventArgs e)
        {
            tbNumber10.Text = (Convert.ToInt32(tbNumber10.Text) - 1).ToString();
            CheckIfSmallerNull();
            ChangingLbSum();
        }

        private void btMinus20_Click(object sender, EventArgs e)
        {
            tbNumber20.Text = (Convert.ToInt32(tbNumber20.Text) - 1).ToString();
            CheckIfSmallerNull();
            ChangingLbSum();
        }

        private void btMinus50_Click(object sender, EventArgs e)
        {
            tbNumber50.Text = (Convert.ToInt32(tbNumber50.Text) - 1).ToString();
            CheckIfSmallerNull();
            ChangingLbSum();
        }

        private void btMinus100_Click(object sender, EventArgs e)
        {
            tbNumber100.Text = (Convert.ToInt32(tbNumber100.Text) - 1).ToString();
            CheckIfSmallerNull();
            ChangingLbSum();
        }

        private void btMinus200_Click(object sender, EventArgs e)
        {
            tbNumber200.Text = (Convert.ToInt32(tbNumber200.Text) - 1).ToString();
            CheckIfSmallerNull();
            ChangingLbSum();
        }

        private void btMinus500_Click(object sender, EventArgs e)
        {
            tbNumber500.Text = (Convert.ToInt32(tbNumber500.Text) - 1).ToString();
            CheckIfSmallerNull();
            ChangingLbSum();
        }

        private void btPlus5_Click(object sender, EventArgs e)
        {
            tbNumber5.Text = (Convert.ToInt32(tbNumber5.Text) + 1).ToString();
            ChangingLbSum();
        }

        private void btPlus10_Click(object sender, EventArgs e)
        {
            tbNumber10.Text = (Convert.ToInt32(tbNumber10.Text) + 1).ToString();
            ChangingLbSum();
        }

        private void btPlus20_Click(object sender, EventArgs e)
        {
            tbNumber20.Text = (Convert.ToInt32(tbNumber20.Text) + 1).ToString();
            ChangingLbSum();
        }

        private void btPlus50_Click(object sender, EventArgs e)
        {
            tbNumber50.Text = (Convert.ToInt32(tbNumber50.Text) + 1).ToString();
            ChangingLbSum();
        }

        private void btPlus100_Click(object sender, EventArgs e)
        {
            tbNumber100.Text = (Convert.ToInt32(tbNumber100.Text) + 1).ToString();
            ChangingLbSum();
        }

        private void btPlus200_Click(object sender, EventArgs e)
        {
            tbNumber200.Text = (Convert.ToInt32(tbNumber200.Text) + 1).ToString();
            ChangingLbSum();
        }

        private void btPlus500_Click(object sender, EventArgs e)
        {
            tbNumber500.Text = (Convert.ToInt32(tbNumber500.Text) + 1).ToString();
            ChangingLbSum();
        }

        private void tbNumber5_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumber10_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumber20_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumber50_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumber100_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumber200_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNumber500_TextChanged(object sender, EventArgs e)
        {

        }

        void SetTextBox0()
        {
            tbNumber5.Text = "0";
            tbNumber10.Text = "0";
            tbNumber20.Text = "0";
            tbNumber50.Text = "0";
            tbNumber100.Text = "0";
            tbNumber200.Text = "0";
            tbNumber500.Text = "0";
        }
        void SetLabels()
        {
            lbFirstName.Text = csv.Customer[CustomerIndex].FirstName;
            lbLastName.Text = csv.Customer[CustomerIndex].LastName;
            lbAccountBalance.Text = "Your Money: " + Convert.ToString(csv.Customer[CustomerIndex].Money) + " €";
        }
        void ChangingLbSum()
        {
            lbMoneySum.Text = "Sum: " + (Convert.ToInt32(tbNumber5.Text) * 5 + Convert.ToInt32(tbNumber10.Text) * 10
                + Convert.ToInt32(tbNumber20.Text) * 20 + Convert.ToInt32(tbNumber50.Text) * 50
                + Convert.ToInt32(tbNumber100.Text) * 100 + Convert.ToInt32(tbNumber200.Text) * 200
                + Convert.ToInt32(tbNumber500.Text) * 500).ToString() + " €";

        }
        void CheckIfSmallerNull()
        {
            if (Convert.ToInt32(tbNumber5.Text) < 0) { tbNumber5.Text = "0"; }
            if (Convert.ToInt32(tbNumber10.Text) < 0) { tbNumber10.Text = "0"; }
            if (Convert.ToInt32(tbNumber20.Text) < 0) { tbNumber20.Text = "0"; }
            if (Convert.ToInt32(tbNumber50.Text) < 0) { tbNumber50.Text = "0"; }
            if (Convert.ToInt32(tbNumber100.Text) < 0) { tbNumber100.Text = "0"; }
            if (Convert.ToInt32(tbNumber200.Text) < 0) { tbNumber200.Text = "0"; }
            if (Convert.ToInt32(tbNumber500.Text) < 0) { tbNumber500.Text = "0"; }
        }

        private void lbFirstName_Click(object sender, EventArgs e)
        {

        }

        private void btTakeOff_Click(object sender, EventArgs e)
        {
            string[] money = lbMoneySum.Text.Split(' ');
            if (Convert.ToInt32(money[1]) <= csv.Customer[CustomerIndex].Money)
            {
                csv.Customer[CustomerIndex].TakeOffMoney = Convert.ToInt32(money[1]);
                string tempString = (CustomerIndex + ";" + money[1] + ";" + DateTime.Now.Date);

                csv.Write(tempString, csv.TransactionCSV);

                MessageBox.Show("Die Transaktion war erfolgreich! \n sie haben: " + money[1] + "€ abgehoben");
                
                SetLabels();
                SetTextBox0();
                ChangingLbSum();
                csv.ChangingCustomerMoney(CustomerIndex, csv.Customer[CustomerIndex].Money);
            } else
            {
                MessageBox.Show("Sie haben nicht genug geld auf ihrem Konto");
            }
        }
    }
}
