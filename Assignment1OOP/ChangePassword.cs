using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1OOP
{
    public partial class ChangePassword : Form
    {
        DAO dao = new DAO();
        SendingData sData = new SendingData();
        private string Username;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        public void setUsername(string username)
        {
            Username = username;
        }

        public string getUsername()
        {
            return Username;
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;

            if (rightPassword(getUsername(), oldPass))
            {
                if (oldPass.Equals(newPass))
                {
                    MessageBox.Show("Your new password must be different from the old one");
                }
                else
                {
                    sData.updatePassword(getUsername(), newPass);
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }

        public bool rightPassword(string username, string password)
        {
            int rowCount = 0;

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspValidPassword";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            rowCount = (int)cmd.ExecuteScalar();
            dao.CloseCon();

            return (rowCount == 1);
        }

   
    }
}
