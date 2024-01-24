using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1OOP
{
    public partial class Payment : Form
    {
        SendingData sData = new SendingData();
        private string Username;
        private double RemFee;

        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            txtBalance.Text = getRemFee().ToString("F3");
        }

        public void setUsernameAndFee(string username, double remFee)
        {
            Username = username;
            RemFee = remFee;
        }

        public string getUsername()
        {
            return Username;
        }

        public double getRemFee()
        {
            return RemFee;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            double paidAmount = double.Parse(txtAmount.Text);
            double newBal = newBalance(getRemFee(), paidAmount);

            sData.updateBalance(getUsername(), newBal);
            sData.addTransaction(getUsername(), getRemFee(), paidAmount, newBal);
            ConfirmPayment cpay = new ConfirmPayment();
            cpay.setDetails(getUsername(), newBal, paidAmount);
            cpay.Show();
            this.Hide();
        }

        private double newBalance(double balance, double paidAmt)
        {
            double newBal = 0;

            if (paidAmt < 0)
            {
                MessageBox.Show("You can't pay less than €0.");
            }
            else if (paidAmt > balance)
            {
                MessageBox.Show("Selected value is greater than your remaining fee.");
            }
            else
            {
                newBal = balance - paidAmt;
            }

            return newBal;
        }
    }
}
