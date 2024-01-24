using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1OOP
{
    internal class Lecturer : Person
    {
        SendingData sData = new SendingData();
        public string Module { get; set; }
        public decimal Pay { get; set; }

        public Lecturer(string fn, string add, char gender, string cy, DateTime dob, string phone, string email, string course, string login, string password, string module, decimal pay)
            : base(fn, add, gender, cy, dob, phone, email, course, login, password)
        {
            Module = module;
            Pay = pay;
        }

        public void addLecturer()
        {
            sData.addLecturerToDB(Name, Username, Gender, Address, County, dateOfBirth, Phone, Email, Course, Module, Pay);
        }

        public void addLecturerLogin()
        {
            sData.addLoginDetails(Username, Password);
        }

    }
}
