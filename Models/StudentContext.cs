
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chacha_project.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> Options) : base(Options)
        {

        }
       

        
        public DbSet<Student>  Students { get; set; }
        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Fee> Fees { get; set; }


    }

}
