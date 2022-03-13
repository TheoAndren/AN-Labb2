using System;
using System.Collections.Generic;
using System.Text;

namespace AN_Labb2.Models
{
    public class Subject
    {

        public Subject()
        {
            Teacher = new HashSet<Teacher>();
        }
        public int SubjectId { get; set; }

        public string SubjectName { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Teacher> Teacher { get; set; }
    }
}
