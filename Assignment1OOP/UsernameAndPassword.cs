using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment1OOP
{
    public partial class UsernameAndPassword : Form
    {
        private string Username;
        private string Password;
        private string Position;

       
        public UsernameAndPassword()
        {
            InitializeComponent();
        }

        private void UsernameAndPassword_Load(object sender, EventArgs e)
        {
            lblUsernameDisplay.Text = getUsername();
            lblPassDisplay.Text = getPassword();
        }

        public void setUsernameAndPassword(string username, string password, string position)
        {
            Username = username;
            Password = password;
            Position = position;
        }

        public string getUsername()
        {
            return Username;
        }

        public string getPassword()
        {
            return Password;
        }

        public string getPosition()
        {
            return Position;
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Position.Equals("Student"))
            {
                StuProfile newStu = new StuProfile();
                newStu.setUsername(getUsername());
                newStu.Show();
                this.Hide();
            }
            else
            {
                LecProfile lecturer = new LecProfile();
                lecturer.setUsername(Username);
                lecturer.Show();
                this.Hide();
            }

            
        }
    }
}
