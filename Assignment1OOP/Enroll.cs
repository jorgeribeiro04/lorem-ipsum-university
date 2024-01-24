using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1OOP
{
  
    public partial class Enroll : Form
    {
        const string POSITION = "Student";
        Random random = new Random();
        DAO dao = new DAO();
    
        public Enroll()
        {
            InitializeComponent();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            const double INITIALDEBIT = 6.300;
            string name = txtName.Text;
            string address = txtAddress.Text;
            char gender = 'M';
            if (rbFemale.Checked)
            {
                gender = 'F';
            }
            string cy = cboCounty.SelectedItem.ToString();
            DateTime dob = DateTime.Parse(dtpEnroll.Text);
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string course = cboCourse.SelectedItem.ToString();
            string studentNumber = random.Next(10000, 100000).ToString();
            string username = txtUsername.Text;
            string password = generatePassword(username);
            

            if (validUsername(username))
            {
                Student student = new Student(name, address, gender, cy, dob, phone, email, course, username, password, studentNumber, INITIALDEBIT);
                student.addStuLogin();
                student.addStudent();
                student.addModules(course);
                UsernameAndPassword uap = new UsernameAndPassword();
                uap.setUsernameAndPassword(username, password, POSITION);
                uap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This username is not available! Please, choose another one.");
                txtUsername.Clear();
            }
            
        }

        private string generatePassword(string name)
        {
            string randomNum = random.Next(100, 1000).ToString();
            string password = String.Concat(name, randomNum);
            return password;
        }

        private bool validUsername(string username)
        {
            int rowCount = 0;

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspValidUsername";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            rowCount = (int)cmd.ExecuteScalar();
            dao.CloseCon();

            return (rowCount == 0);
        }

        private void Enroll_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboCourse.DataSource = Enum.GetValues(typeof(Courses));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
