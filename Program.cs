using System;
using System.Linq;

namespace Anonymous_types_ar
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student() { ID = 1, Name = "Ahmed Mohamed" };
            Console.WriteLine(s1.Name);

            var e1 = new  { ID = 1, Name = "Mohamed Fathy", Salary = 10000, Age = 40};
            Console.WriteLine($"ID = {e1.ID}, Name = {e1.Name}");

            var students = new[] { new Student() { ID = 1, Name = "Ahmed Mohamed" }, new Student() { ID = 2, Name = "Gana Mohamed"} };
            var selected = from s in students select new { s.Name };
            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }
        }
    }
}
