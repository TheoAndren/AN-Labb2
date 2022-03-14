using AN_Labb2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AN_Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using SchoolDbContext context = new SchoolDbContext();


            // Ta fram lärare som undervisar matte
            var c = from k in context.Teachers where k.SubjectId == 6 select k;

            foreach (var item in c)
            {
                Console.WriteLine("Lärare som undervisar kursen Math 1");
                Console.WriteLine("");
                Console.WriteLine("{0}", item.TeacherName);
                Console.WriteLine("------------------------------------------");
            }

            //Kolla om tabellen subjects innehåller Programmering 1
            var query =
               from x in context.Subjects
               where x.SubjectName.Contains("Programming 1")
               orderby x.SubjectName
               select x;
           
            foreach (var course in query)
            {
                Console.WriteLine("");
                Console.WriteLine(" The Course Programming 1 does exist");
                Console.WriteLine("------------------------------------------");
            }

            // Hämta elever med alla sina lärare
            var courses =
                from v in context.Courses
                join a in context.Teachers on v.CourseId equals a.CourseId
                join b in context.Students on v.CourseId equals b.CourseId
                select new { StudentName = b.StudentName, TeacherName = a.TeacherName};

            foreach (var item in courses)
            {
                Console.WriteLine("Student: " + item.StudentName + " " + "Teacher: " + item.TeacherName);
            }







            //var courses = new List<Course> {
            //    new Course { CourseName = "SUT20" },
            //    new Course { CourseName = "MJ20" },
            //    new Course { CourseName = "NK20" },
            //    new Course { CourseName = "SP20" }
            //}; context.AddRange(courses);
            //context.SaveChanges();


               //            var students = new List<Student>{
               //    new Student { StudentName = "Kalle Persson" , CourseId = 1},
               //    new Student { StudentName = "Carl Gustaffsson" , CourseId = 2},
               //    new Student { StudentName = "Anja Persson" , CourseId = 3},
               //    new Student { StudentName = "Sven Karlsson" , CourseId = 4},
               //    new Student { StudentName = "Olle Klementin" , CourseId = 4},
               //    new Student { StudentName = "Oscar Oscarsson" , CourseId = 1 }
               //}; context.AddRange(students);
               //            context.SaveChanges();




               //var teachers = new List<Teacher>{
               //    new Teacher { TeacherName = "Karl Harryson" , CourseId = 1, SubjectId = 1},
               //    new Teacher { TeacherName = "Tobias Qlok" , CourseId = 1, SubjectId = 2},
               //    new Teacher { TeacherName = "Anas Qlok" , CourseId = 1, SubjectId = 4},
               //    new Teacher { TeacherName = "Reidar Qlok" , CourseId = 1, SubjectId = 5},
               //    new Teacher { TeacherName = "Billy Sneider" , CourseId = 2, SubjectId = 7},
               //    new Teacher { TeacherName = "Magdalena Svensson" , CourseId = 3, SubjectId = 3},
               //    new Teacher { TeacherName = "Birgitta Karlsson" , CourseId = 3, SubjectId = 8},
               //    new Teacher { TeacherName = "Ola Konradsson" , CourseId = 4, SubjectId = 6}
               //}; context.AddRange(teachers);
               //context.SaveChanges();





               //            var subjects = new List<Subject>{
               //    new Subject { SubjectName = "OOP" , CourseId = 1},
               //    new Subject { SubjectName = "Programming with C#" , CourseId = 1},
               //    new Subject { SubjectName = "HRL" , CourseId = 3},
               //    new Subject { SubjectName = "Programming 1" , CourseId = 1},
               //    new Subject { SubjectName = "Porgramming 2" , CourseId = 1},
               //    new Subject { SubjectName = "Math 1" , CourseId = 4},
               //    new Subject { SubjectName = "Software Development 1" , CourseId = 2},
               //    new Subject { SubjectName = "CPR" , CourseId = 3}
               //}; context.AddRange(subjects);
               //            context.SaveChanges();

        }
    }
}
