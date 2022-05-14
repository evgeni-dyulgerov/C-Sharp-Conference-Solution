using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp9.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name is too long")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "First name is too long")]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<string> Extras { get; set; }
        
    }
}
