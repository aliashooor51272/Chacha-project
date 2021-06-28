using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chacha_project.Models
{
    public class Fee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string StudentName { get; set; }
        [Required]
        public string FatherName { get; set; }

        [Required]
        public int RegistrationNo { get; set; }
        [Required]
        public string StudentCNIC { get; set; }
      
        [Required]
        public string Phone { get; set; }
    }
}
