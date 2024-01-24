using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1OOP
{

    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public string County { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }    
        public string Course { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public Person(string fn, string add, char gender, string cy, DateTime dob, string phone, string email, string course, string username, string password)
        {
            Name = fn;
            Address = add;
            Gender = gender;
            County = cy;
            dateOfBirth = dob;
            Phone = phone;
            Email = email;
            Course = course;
            Username = username;
            Password = password;
        }






    }
}
