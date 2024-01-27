using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _00010358.Models
{
    public class Student
    {

        //Changes the name in the MVC
        [DisplayName("ID")]
        public int StudentID { get; set; }

        //Changes the name in the MVC
        [DisplayName("First Name")]
        //error message if empty
        [Required(ErrorMessage = "Enter your first name here!")]
        public string FirstName { get; set; }

        //Changes the name in the MVC
        [DisplayName("Last Name")]
        //error message if empty
        [Required(ErrorMessage = "Enter your last name here!")]
        public string LastName { get; set; }

        //added email validation which only accepts emails ending with @gmail.com
        [EmailAddress]
        //error message if empty
        [Required(ErrorMessage = "Enter your gmail address here!")]
        [RegularExpression(@"\w+([-+.]\w+)*@(gmail\.com)", ErrorMessage = "Enter your gmail address here!")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Enter your age here!")]
        public int Age { get; set; }

        //added phone number validation which only accepts number starting with +9989...
        [Phone]
        //error message if empty
        [Required(ErrorMessage = "Enter your phone here!")]
        [RegularExpression(@"^[+]{1}[9]{1}[9]{1}[8]{1}[9]{1}[0-9]{8}$", ErrorMessage = "Enter your phone number starting with +9989...!")]
        public string Phone { get; set; }

        //Changes the name in the MVC
        [DisplayName("Course ID")]
        //error message if empty
        [Required(ErrorMessage = "Please select one of the options")]
        public int CourseId { get; set; }
    }
}
