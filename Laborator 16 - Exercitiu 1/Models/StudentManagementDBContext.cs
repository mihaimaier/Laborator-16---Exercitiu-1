using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_16___Exercitiu_1.Models
{
    class StudentManagementDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public StudentManagementDBContext() :base()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Iugkn\Desktop\C#.Net Course\Lab#16 - LINQ Cont, SQL, Entity Framework\Laborator 16 - Exercitiu 1\Laborator 16 - Exercitiu 1\StudentManagement.mdf; Integrated Security = True");
        }
    }
}
