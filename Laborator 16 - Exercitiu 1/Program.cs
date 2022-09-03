using Laborator_16___Exercitiu_1.Models;
using System;
using System.Linq;

namespace Laborator_16___Exercitiu_1
{
    class Program
    {
        static void Main(string[] args)
        {
            SeedTable();
            using StudentManagementDBContext context = new StudentManagementDBContext();

            // Afisati toti studentii din DB in ordine alfabetica
            context.Students.OrderBy(s => s.FirstName).ToList().ForEach(s => Console.WriteLine(s));
            context.SaveChanges();

            Console.WriteLine();

            //Afisati cel mai tanar student de la constructii cu varsta de peste 20 de ani.

            var youngestStudentConstruction = context.Students.Where(s => s.Age > 20 && s.Major == Major.Construction).FirstOrDefault();
            Console.WriteLine(youngestStudentConstruction);
            context.SaveChanges();

        }

        static void SeedTable()
        {
            using var ctx = new StudentManagementDBContext();

            if (ctx.Students.Count() != 0)
            {
                return;
            }
            ctx.Students.Add(new Student
            {
                Age = 25,
                FirstName = "Florin",
                LastName = "Marin",
                Major = Major.Construction
            });
            ctx.Students.Add(new Student
            {
                Age = 33,
                FirstName = "Alexandra",
                LastName = "Tampa",
                Major = Major.IT
            });
            ctx.Students.Add(new Student
            {
                Age = 39,
                FirstName = "Remus",
                LastName = "Pirvu",
                Major = Major.Letters
            });
            ctx.Students.Add(new Student
            {
                Age = 16,
                FirstName = "Darius",
                LastName = "Jucan",
                Major = Major.Construction
            });
            ctx.Students.Add(new Student
            {
                Age = 21,
                FirstName = "Alexandru",
                LastName = "Manolache",
                Major = Major.IT
            });
            ctx.Students.Add(new Student
            {
                Age = 41,
                FirstName = "Razvan",
                LastName = "Buboi",
                Major = Major.Construction
            });
            ctx.Students.Add(new Student
            {
                Age = 24,
                FirstName = "Carmen",
                LastName = "Popovici",
                Major = Major.Letters
            });
        }
    }
}
