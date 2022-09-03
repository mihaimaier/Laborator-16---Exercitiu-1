using System;
using System.Collections.Generic;
using System.Text;

namespace Laborator_16___Exercitiu_1.Models
{
    class Student
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Major Major { get; set; }

        public Student()
        {
            this.Id = Id;
        }

        public override string ToString() =>
        $"{Id} {FirstName} {LastName} {Age} {Major}";
    }
}
