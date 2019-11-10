using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EducationalInstituteForComputerMVC.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string CourseName { get; set; }
        public List<Student> Students { get; set; }
    }
}
