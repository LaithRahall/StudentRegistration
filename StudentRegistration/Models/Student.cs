using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentRegistration.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Range(5,18)]
        public int Age { get; set; }
        public DateTime RegistrationDate { get; set; }
    }
}
