using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Assignment1OOP
{
    internal class SendingData : DAO
    {
        public void addStudentToDB(string name, string username, string address, char gender,
           string county, DateTime age, string phone, string email, string stuNum, string course, double balance)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddStudent";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fn", name);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@cy", county);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@stuNum", stuNum);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@balance", balance);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void addLecturerToDB(string name, string username, char gender, string address, string cy,
         DateTime dob, string phone, string email, string course, string module, decimal pay)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddLecturer";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@fn", name);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@add", address);
            cmd.Parameters.AddWithValue("@cy", cy);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@course", course);
            cmd.Parameters.AddWithValue("@module", module);
            cmd.Parameters.AddWithValue("@pay", pay);

            cmd.ExecuteNonQuery();
            CloseCon();

        }

        public void addModules(string username, string course, string[] modules)
        {
            foreach (string module in modules)
            {
                int grade = 0;

                SqlCommand cmd = OpenCon().CreateCommand();
                cmd.CommandText = "uspAddModules";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@module", module);
                cmd.Parameters.AddWithValue("@grade", grade);

                cmd.ExecuteNonQuery();
                CloseCon();
            }
        }

        public void addLoginDetails(string username, string password)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddLoginDetails";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void addTransaction(string username, double pBalance, double amtPaid, double newBal)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspAddTransaction";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@pBalance", pBalance);
            cmd.Parameters.AddWithValue("@paidAmt", amtPaid);
            cmd.Parameters.AddWithValue("@newBalance", newBal);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

        public void updateBalance(string username, double newBal)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "updateBalance";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@newBalance", newBal);

            cmd.ExecuteNonQuery();
            CloseCon();

        }

        public void updatePassword(string username, string password)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspUpdatePassword";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            cmd.ExecuteNonQuery();

            CloseCon();

            MessageBox.Show("Password updated successfully");
        }

        public void uptdateGrade(int grade, string username, string module)
        {
            SqlCommand cmd = OpenCon().CreateCommand();
            cmd.CommandText = "uspUpdateGrade";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@grade", grade);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@module", module);

            cmd.ExecuteNonQuery();
            CloseCon();
        }

    }
}
