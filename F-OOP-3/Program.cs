using System;
using System.Collections;
namespace F_OOP_3
{
    class Student
    {
        public string id { get; set; }
        public string name { get; set; }
        public double mark { get; set; }
    }

    class Program
    {
        static void Main()
        {
            ArrayList ST = new ArrayList();
            // NST : number of student
            Console.Write("Enter the number of students (5-10): ");
            int NSt = int.Parse(Console.ReadLine());


            for (int i = 0; i < NSt; i++)
            {
                Console.WriteLine($"Enter details for student {i + 1}:");
                Console.Write("ID: ");
                string id = Console.ReadLine();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Mark: ");
                double mark = double.Parse(Console.ReadLine());

                Student Si = new Student { id = id, name = name, mark = mark };
                ST.Add(Si);
            }

            Console.WriteLine("Students who passed:");
            foreach (Student item in ST)
            {
                if (item.mark >= 50)
                {
                    Console.WriteLine(item.name);
                }
            }
        }
    }
}
