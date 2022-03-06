using System;
using System.Collections.Generic;
using System.Text;

namespace AN_Labb2.Models
{
    public class Subject
    {
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public int CourseId { get; set; }

        public Course Course { get; set; }
    }
}
