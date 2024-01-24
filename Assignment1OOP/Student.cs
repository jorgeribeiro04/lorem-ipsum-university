using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1OOP
{
    public class Student : Person
    {
        SendingData sData = new SendingData();
        public string StudentNumber { get; set; }
    
        public double InitialDebt { get; set; }

        public Student(string fn, string add, char gender, string cy, DateTime dob, string phone, string email, string course, string login, string password, string studentNum, double initialDebt)
            : base(fn, add, gender, cy, dob, phone, email, course, login, password)
        {
            StudentNumber = studentNum;
            InitialDebt = initialDebt;
        }

        public void addStudent()
        {
            sData.addStudentToDB(Name, Username, Address, Gender, County, dateOfBirth, Phone, Email, StudentNumber, Course, InitialDebt);
        }

        public void addStuLogin()
        {
            sData.addLoginDetails(Username, Password);
        }

        public void addModules(string course)
        {
            string[] modules;

            if (course.Equals("Computing"))
            {
                modules = new string[] {"ProgrammingFundamentals", "OOP", "WebDevelopment", "CloudComputing", "ComputerArchitecture"};
            }
            else if (course.Equals("Law"))
            {
                modules = new string[] {"LandLaw", "Constitutional", "Jurisprudence", "Criminal", "Contract"};
            }
            else if (course.Equals("Business"))
            {
                modules = new string[] { "Analytics", "BrandManagement", "CorporateFinance", "DigitalMkt", "Accounting" };
            }
            else
            {
                modules = new string[] {"Introduction", "DigitalContext", "MktStrategys", "Communication", "BusinessLaw"};
            }

            sData.addModules(Username, Course, modules);
        }





    }
}
