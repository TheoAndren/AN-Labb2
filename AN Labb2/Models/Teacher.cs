using System;
using System.Collections.Generic;
using System.Text;

namespace AN_Labb2.Models
{
    public class Teacher
    {
        public int TeacherId { get; set; }

        public int SubjectId { get; set; }

        public int? CourseId { get; set; }

        public string TeacherName { get; set; }

        public virtual Course Course { get; set; }
        public virtual Subject Subject { get; set; }
    }
}
