using System;
using System.Collections.Generic;
using System.Text;

namespace AN_Labb2.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public int SubjectId { get; set; }

        public string TeacherName { get; set; }

        public Subject Subject { get; set; }
    }
}
