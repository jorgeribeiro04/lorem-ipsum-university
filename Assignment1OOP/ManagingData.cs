using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Reflection;

namespace Assignment1OOP
{
    internal class ManagingData : DAO
    {
        DataTable dt;
        SqlDataAdapter da;

        public DataTable showAllData(string username, string sProcedure)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();
            
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = sProcedure;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;

        }

        public DataTable showLecturers()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspSelectLecturers";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }
        
        public DataTable filteringByGender(char gender)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowLecturersByGender";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@gender", gender);

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable showAllStudents()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowAllStudents";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable showMyStudents(string course, string module)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowMyStudents";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@module", module);

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable showLecturerByCourse(string course)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowLecturersByCourse";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@course", course);

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable showStuGrades(string module)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowGrades";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@module", module);

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable showStudentsInDebt()
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowStuInDebt";
            cmd.CommandType = CommandType.StoredProcedure;

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable sortingGrades(string sProcedure, string username)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = sProcedure;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable filteringStuByGender(char gender)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowStuByGender";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@gender", gender);

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable filteringStuByCourse(string course)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspShowStuByCourse";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@course", course);

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable filteringStuByGrades(string sProcedure, string module)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = sProcedure;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@module", module);
            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }

        public DataTable filteringStuByAge(string sProcedure, DateTime date)
        {
            da = new SqlDataAdapter();
            dt = new DataTable();

            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = sProcedure;
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dob", date);

            da.SelectCommand = cmd;
            da.Fill(dt);
            CloseCon();

            return dt;
        }
    }
}
