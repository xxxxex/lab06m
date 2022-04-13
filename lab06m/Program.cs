using System;
using System.Collections.Generic;

namespace lab06m
{
    class Student
    {
        public string Name { get; set; }

        public int Ects { get; set; }

        public override bool Equals(object obj)
        {
            Console.WriteLine("Student Equals");
            return obj is Student student &&
                Name == student.Name &&
                Ects == student.Ects;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICollection<string> names = new List<string>();
            names.Add("ewa");
            names.Add("karol");
            names.Add("adam");
            names.Add("adam");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine(names.Contains("ewa"));
            Console.WriteLine(names.Remove("adam"));

            //operacje na kolekcji studentów

            ICollection<Student> students = new List<Student>(); //rzutowanie niejawne ze szczegółu na ogół
            students.Add(new Student { Name = "Filip", Ects = 3 });
            students.Add(new Student { Name = "Magda", Ects = 5 });
            students.Add(new Student { Name = "Jan", Ects = 7 });
            students.Add(new Student { Name = "Monika", Ects = 9 });
            foreach (var student in students)
            {
                Console.WriteLine(student.Name+" "+student.Ects);
            }
            Console.WriteLine(students.Contains(new Student() { Name = "Jan", Ects = 7 }));
            Console.WriteLine(students.Remove(new Student() { Name = "Monika", Ects = 9 }));
            List<Student> list = (List<Student>)students; //rzutowanie jawne z ogół na szczegół
            Console.WriteLine(list[0]);

        }
    }
}
