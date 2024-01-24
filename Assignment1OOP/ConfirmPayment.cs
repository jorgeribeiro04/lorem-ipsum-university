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
    public partial class ConfirmPayment : Form
    {
        StuProfile updtStu = new StuProfile();
        private string Username;
        private double NewBalance;
        private double PaidAmount;
        public ConfirmPayment()
        {
            InitializeComponent();
        }

        private void btnApproved_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You paid €{getPaidAmount().ToString("F3")}. Your new debt is €{getNewBalance().ToString("F3")}");
            updtStu.setUsername(getUsername());
            updtStu.Show();
            this.Hide();
        }

        public void setDetails(string username, double newBalance, double paidAmt)
        {
            Username = username;
            NewBalance = newBalance;
            PaidAmount = paidAmt;
        }

        public string getUsername()
        {
            return Username;
        }

        public double getNewBalance()
        {
            return NewBalance;
        }

        public double getPaidAmount()
        {
            return PaidAmount;
        }

        private void ConfirmPayment_Load(object sender, EventArgs e)
        {

        }
    }
}
