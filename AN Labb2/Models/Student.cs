using System;
using System.Collections.Generic;
using System.Text;

namespace AN_Labb2.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public int CourseId { get; set; }

        public string StudentName { get; set; }

        public virtual Course Course { get; set; }
    }
}
