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
    public partial class Work : Form
    {
        const string POSITION = "Lecturer";
        Random randomNum = new Random();
        DAO dao = new DAO();

        public Work()
        {
            InitializeComponent();
        }

        private void Work_Load(object sender, EventArgs e)
        {
            cboCounty.DataSource = Enum.GetValues(typeof(County));
            cboCourse.DataSource = Enum.GetValues(typeof(Courses));          
        }

        private void populatingModules(string course)
        {
            switch (course)
            {
                case "Computing":
                    cboModule.DataSource = Enum.GetValues(typeof(Computing));
                    break;
                case "Law":
                    cboModule.DataSource = Enum.GetValues(typeof(Law));
                    break;
                case "Marketing":
                    cboModule.DataSource = Enum.GetValues(typeof(Marketing));
                    break;
                case "Business":
                    cboModule.DataSource = Enum.GetValues(typeof(Business));
                    break;
            }
        }

        private void cboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            string course = cboCourse.SelectedItem.ToString();
            populatingModules(course);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            string fn = txtName.Text;
            string username = txtUsername.Text;
            char gender = 'M';
            if (rbFemale.Checked)
            {
                gender = 'F';
            }
            string address = txtAddress.Text;
            string cy = cboCounty.SelectedItem.ToString();
            DateTime dob = DateTime.Parse(dtpDOB.Text);
            string phone = txtPhone.Text;
            string email = txtEmail.Text;
            string course = cboCourse.SelectedItem.ToString();
            string module = cboModule.SelectedItem.ToString();
            decimal pay = Convert.ToDecimal(txtPay.Text);
            string password = generatePassword(username);
            if (validUsername(username))
            {
                Lecturer newLec = new Lecturer(fn,address,gender,cy,dob,phone,email,course,username,password,module,pay);
                newLec.addLecturer();
                newLec.addLecturerLogin();
                UsernameAndPassword uap = new UsernameAndPassword();
                uap.setUsernameAndPassword(username, password, POSITION);
                uap.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This username is already been used. Please, try another one!");
                txtUsername.Clear();
            }

        }

       private string generatePassword(string username)
        {
            string password;
            string number = randomNum.Next(100,1000).ToString();
            password = String.Concat(username, number);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
