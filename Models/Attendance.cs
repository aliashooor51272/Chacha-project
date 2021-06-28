using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Chacha_project.Models
{
    public class Attendance
    {
        [Key]
        public int AttendenceId { get; set; }
        public string Present { get; set; }
        public string Absent { get; set; }
        public string Leaves { get; set; }
        public DateTime EnterTime { get; set; }
    }
}
