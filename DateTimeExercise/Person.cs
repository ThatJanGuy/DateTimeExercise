using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExercise
{
    internal class Person
    {
        public Person(int? id, string? name, DateTime? dateOfBirth)
        {
            Name = name;
            Id = id;
            DateOfBirth = dateOfBirth;
        }

        public int? Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DateOfBirth { get; set; }   
    }
}
