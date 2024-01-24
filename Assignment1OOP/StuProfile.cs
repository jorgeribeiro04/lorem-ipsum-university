using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1OOP
{
    public partial class StuProfile : Form
    {
        ManagingData md = new ManagingData();
        SqlDataReader dr;
        DAO dao = new DAO();

        private string StdProcedure;
        private string Username;
        private string name;
        private string course;
        private double balance;
        private string stuNum;
        
        public StuProfile()
        {
            InitializeComponent();
        }

        private void StuProfile_Load(object sender, EventArgs e)
        {
            
            fillingDetails(getUsername());
        }

        public void setUsername(string name)
        {
            Username = name;
        }

        public string getUsername()
        {
            return Username;
        }


        public void fillingDetails(string username)
        {
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspFillStuProfile";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                name = dr["Name"].ToString();
                course = dr["Course"].ToString();
                stuNum = dr["StudentNum"].ToString();
                balance = double.Parse(dr["Balance"].ToString());
            }

            dao.CloseCon();

            lblNameDisplay.Text = name;
            lblCourseDisplay.Text = course;
            lblBalanceDisplay.Text = balance.ToString("F3");
            lblStuNumDisplay.Text = stuNum;
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.setUsernameAndFee(Username, balance);
            pay.Show();
            this.Hide();
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            cboFilter.Visible = false;
            cboFilter2.Visible = false;
            StdProcedure = "uspMyTransactions";
            dgvStudent.DataSource = false;
            dgvStudent.DataSource = md.showAllData(getUsername(), StdProcedure);
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            cboFilter.Visible = false;
            cboFilter2.Visible = false;

            StdProcedure = "uspShowModules";
            dgvStudent.DataSource = false;
            dgvStudent.DataSource = md.showAllData(getUsername(), StdProcedure);
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            cboFilter.Visible = true;
            cboFilter.DataSource = Enum.GetValues(typeof(Grades));
            cboFilter2.Visible = false;

            StdProcedure = "uspMyGrades";
            dgvStudent.DataSource = false;
            dgvStudent.DataSource = md.showAllData(getUsername(), StdProcedure);
        }

        private void btnLecturers_Click(object sender, EventArgs e)
        {
            cboFilter.Visible = true;
            cboFilter.DataSource = Enum.GetValues(typeof(Lecturers));
            cboFilter2.Visible = true;

            dgvStudent.DataSource = false;
            dgvStudent.DataSource = md.showLecturers();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cboFilter.SelectedItem.ToString();

            switch (filter)
            {
                case "ByGender":
                    cboFilter2.DataSource = Enum.GetValues(typeof(Gender));
                    break;
                case "ByCourse":
                    cboFilter2.DataSource = Enum.GetValues(typeof(Courses));
                    break;
                case "Sufficient":
                    StdProcedure = "uspSufficientGrades";
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.sortingGrades(StdProcedure, Username);
                    break;
                case "Insufficient":
                    StdProcedure = "uspInsufficientGrades";
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.sortingGrades(StdProcedure,Username);
                    break;
                case "LowToHigh":
                    StdProcedure = "uspSortGradesLowToHigh";
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.sortingGrades(StdProcedure,Username);
                    break;
                case "HighToLow":
                    StdProcedure = "uspSortGradesHighToLow";
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.sortingGrades(StdProcedure,Username);
                    break;
            }
        }

        private void cboFilter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cboFilter2.SelectedItem.ToString();
            char gender = 'M';

            switch (filter)
            {
                case "Male":
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.filteringByGender(gender);
                    break;
                case "Female":
                    gender = 'F';
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.filteringByGender(gender);
                    break;
                case "Computing":
                    course = "Computing";
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.showLecturerByCourse(course);
                    break;
                case "Law":
                    course = "Law";
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.showLecturerByCourse(course);
                    break;
                case "Business":
                    course = "Business";
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.showLecturerByCourse(course);
                    break;
                case "Marketing":
                    course = "Marketing";
                    dgvStudent.DataSource = false;
                    dgvStudent.DataSource = md.showLecturerByCourse(course);
                    break;           

            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changePass = new ChangePassword();
            changePass.setUsername(Username);
            changePass.Show();
        }
    }
}
