
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _00010358.DAL
{
    public class Student
    {
        // In order to access the data Models folder has been created
        // with below given properties in Student class 

        public int StudentID { get; set; }


        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string Email { get; set; }

        public int Age { get; set; }

        public string Phone { get; set; }

        public int CourseId { get; set; }

    }
}
