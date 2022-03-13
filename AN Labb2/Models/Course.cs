using System;
using System.Collections.Generic;
using System.Text;

namespace AN_Labb2.Models
{
    public class Course
    {
        public Course()
        {
            Student = new HashSet<Student>();
            Subject = new HashSet<Subject>();
            Teacher = new HashSet<Teacher>();
        }
        public int CourseId { get; set; }

        public string CourseName { get; set; }

        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<Subject> Subject { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
