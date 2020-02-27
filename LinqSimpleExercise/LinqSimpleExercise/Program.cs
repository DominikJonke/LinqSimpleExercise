using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSimpleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();

            student.Add(new Student
            {
                ID = "1",
                Name = "Dominik"
            });

            student.Add(new Student
            {
                ID = "2",
                Name = "Janine"
            });

            student.Add(new Student
            {
                ID = "3",
                Name = "Rene"
            });

            var result = from s in student
                            where s.ID.Contains("3")
                            select s.Name;

            Console.WriteLine(result.First());

            Console.ReadKey();
        }
    }
}
