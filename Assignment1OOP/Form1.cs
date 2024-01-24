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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            Enroll enroll = new Enroll();
            enroll.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            Work wk = new Work();
            wk.Show();
            this.Hide();
        }
    }
}
