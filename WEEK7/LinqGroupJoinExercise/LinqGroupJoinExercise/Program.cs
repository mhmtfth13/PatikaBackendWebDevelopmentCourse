using LinqGroupJoinExercise;
using System;

namespace PatikaWeek7.LinqGroupJoinExercise
{
    public class Program
    {
        public static void Main (string[] args)
        {
            List<Student> students = new List<Student> ();
            students.Add(new Student { StudentId = 1, StudentName = "Ali",  ClassId = 1 });
            students.Add(new Student { StudentId = 2, StudentName = "Ayse", ClassId = 2 });
            students.Add(new Student { StudentId = 3, StudentName = "Mehmet", ClassId = 1 });
            students.Add(new Student { StudentId = 4, StudentName = "Fatma", ClassId = 3 });
            students.Add(new Student { StudentId = 5, StudentName = "Ahmet", ClassId = 2 });

            List<Classes> classs = new List<Classes> ();
            classs.Add(new Classes { ClassId = 1, ClassName = "Matematik"});
            classs.Add(new Classes { ClassId = 2, ClassName = "Turkce" });
            classs.Add(new Classes { ClassId = 3, ClassName = "Kimya" });




            var query1 = from c in classs
                         join s in students on c.ClassId equals s.ClassId into StudentGroup
                         select new
                         {
                             ClassName = c.ClassName,
                             Students = StudentGroup
                         };
            foreach (var x in query1)
            {
                Console.WriteLine($"Class: {x.ClassName}");
                foreach (var y in x.Students)
                {
                    Console.WriteLine($"Student: {y.StudentName}");
                }
                Console.WriteLine();
            }
        }
    }
}