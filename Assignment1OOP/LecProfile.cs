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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment1OOP
{
    public partial class LecProfile : Form
    {
        SqlDataReader dr;
        DAO dao = new DAO();
        ManagingData md = new ManagingData();

        private string Username;
        private string Name;
        private string Course;
        private string Module;
        private string StdProcedure;
        public LecProfile()
        {
            InitializeComponent();
        }

        private void LecProfile_Load(object sender, EventArgs e)
        {
            fillLecturerDetails(getUsername());
            cboFilter.DataSource = Enum.GetValues(typeof(Students));
            dgvLecturer.DataSource = false;

        }

        public void setUsername(string username)
        {
            Username = username;
        }

        public string getUsername()
        {
            return Username;
        }

        public void fillLecturerDetails(string name)
        {
            
            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspFillLecturer";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", name);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
               Name = dr["Name"].ToString();
               Course = dr["Course"].ToString();
               Module = dr["Module"].ToString();
            }

            dao.CloseCon();

            lblCourseDisplay.Text = Course;
            lblLecIDDisplay.Text = getUsername();
            lblModuleDisplay.Text = Module;
            lblLecNameDisplay.Text = Name;
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            cboFilter.DataSource = Enum.GetValues(typeof(Students));
            cboFilter.Visible = true;
            cboFilters.Visible = true;
            btnGradeStudent.Visible = false;

            dgvLecturer.DataSource = false;
            dgvLecturer.DataSource = md.showAllStudents();
        }

        private void btnMyStudents_Click(object sender, EventArgs e)
        {
            cboFilter.Visible = false;
            cboFilters.Visible = false;
            btnGradeStudent.Visible = false;
            Course = lblCourseDisplay.Text;
            dgvLecturer.DataSource = false;
            dgvLecturer.DataSource = md.showMyStudents(Course, Module);
        }

        private void btnStuGrades_Click(object sender, EventArgs e)
        {
            cboFilter.DataSource = Enum.GetValues(typeof(Grades));
            cboFilter.Visible = true;
            cboFilters.Visible = false;
            btnGradeStudent.Visible = true;

            dgvLecturer.DataSource = false;
            dgvLecturer.DataSource = md.showStuGrades(Module);
        }

        private void btnInDebt_Click(object sender, EventArgs e)
        {
            cboFilter.Visible = false;
            cboFilters.Visible = false;
            btnGradeStudent.Visible = false;

            dgvLecturer.DataSource = false;
            dgvLecturer.DataSource = md.showStudentsInDebt();
        }

        private void btnGradeStudent_Click(object sender, EventArgs e)
        {
            Grade g = new Grade();
            g.setModule(Module);
            g.Show();
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cboFilter.SelectedItem.ToString();

            switch (filter)
            {
                case "ByGender":
                    cboFilters.DataSource = Enum.GetValues(typeof(Gender));
                    break;
                case "ByCourse":
                    cboFilters.DataSource = Enum.GetValues(typeof(Courses));
                    break;
                case "ByAge":
                    cboFilters.DataSource = Enum.GetValues(typeof(Age));
                    break;
                case "Sufficient":
                    StdProcedure = "uspShowStuSuffGrades";
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByGrades(StdProcedure, Module);
                    break;
                case "Insufficient":
                    StdProcedure = "uspShowStuInsuffGrades";
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByGrades(StdProcedure, Module);
                    break;
                case "LowToHigh":
                    StdProcedure = "uspSortStuGradesLowToHigh";
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByGrades(StdProcedure,Module);
                    break;
                case "HighToLow":
                    StdProcedure = "uspSortStuGradesHighToLow";
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByGrades(StdProcedure,Module);
                    break;
            }
        }

        private void cboFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cboFilters.SelectedItem.ToString();
            char gender = 'M';

            switch (filter)
            {
                case "Male":
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByGender(gender);
                    break;
                case "Female":
                    gender = 'F';
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByGender(gender);
                    break;
                case "Computing":
                    Course = cboFilters.SelectedItem.ToString();
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByCourse(Course);
                    break;
                case "Marketing":
                    Course = cboFilters.SelectedItem.ToString();
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByCourse(Course);
                    break;
                case "Law":
                    Course = cboFilters.SelectedItem.ToString();
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByCourse(Course);
                    break;
                case "Business":
                    Course = cboFilters.SelectedItem.ToString();
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByCourse(Course);
                    break;
                case "Above25":
                    int year = (int)DateTime.Today.Year - 25;
                    DateTime above25 = new DateTime(year, DateTime.Today.Month, DateTime.Today.Day, 00, 00, 00);
                    StdProcedure = "uspShowStuAbove25";
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByAge(StdProcedure, above25);
                    break;
                case "Below25":
                    year = (int)DateTime.Today.Year - 25;
                    int today = (int)DateTime.Today.Day;
                    DateTime below25 = new DateTime(year, DateTime.Today.Month, today + 1, 00,00,00);
                    StdProcedure = "uspShowStuBelow25";
                    dgvLecturer.DataSource = false;
                    dgvLecturer.DataSource = md.filteringStuByAge(StdProcedure, below25);
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
