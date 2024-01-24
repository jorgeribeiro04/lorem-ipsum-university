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
    public partial class Grade : Form
    {
        DAO dao = new DAO();
        private string Module;
        public Grade()
        {
            InitializeComponent();
        }

        private void Grade_Load(object sender, EventArgs e)
        {
            lblModuleDisplay.Text = getModule();
            populateComboBox(Module);
        }
        
        public void setModule(string module)
        {
            Module = module;
        }

        public string getModule()
        {
            return Module;
        }

        public void populateComboBox(string module)
        {
            SqlDataReader dr;

            SqlCommand cmd = dao.OpenCon().CreateCommand();
            cmd.CommandText = "uspPopCombo";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@module", module);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string username = dr["Username"].ToString();
                cboStudent.Items.Add(username);
            }

            dao.CloseCon();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            int grade = int.Parse(txtGrade.Text);
            string username = cboStudent.SelectedItem.ToString();

            if(grade < 0)
            {
                MessageBox.Show("Grade can't be less than 0.");
                txtGrade.Clear();
            }
            else if(grade > 100)
            {
                MessageBox.Show("Grade can't be greater than 100.");
                txtGrade.Clear();
            }
            else
            {
                SendingData sData = new SendingData();
                sData.uptdateGrade(grade, username, getModule());
                this.Hide();
            }
        }
    }
}
