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
    public partial class Login : Form
    {
        DAO dao = new DAO();
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ckbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else txtPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtIdNumber.Text;
            string password = txtPassword.Text;

            if(validLogin(username, password) && rbStudent.Checked && isStudent(username))
            {
                StuProfile student = new StuProfile();
                student.setUsername(username);
                student.Show();
                this.Hide();
            }
            else if(validLogin(username, password) && rbLecturer.Checked && !isStudent(username))
            {
                LecProfile lecturer = new LecProfile();
                lecturer.setUsername(username);
                lecturer.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password! Please, try again.");
            }
        }

        private bool validLogin(string username, string password)
        {
            int countRow = 0;

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspValidLogin";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);
            countRow = (int)cmd.ExecuteScalar();
            dao.CloseCon();

            return (countRow == 1);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private bool isStudent(string username)
        {
            int countRow = 0;

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspIsStudent";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            countRow = (int)cmd.ExecuteScalar();
            dao.CloseCon();

            return (countRow == 1);
        }
    }
}
