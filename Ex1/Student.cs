using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Student:Person
    {
        private int UniqueClassNumber { get; set; }
      
        public Student(string Name, string lastName, int UniqueClassNumber)
            : base(Name, lastName)
        {
            this.UniqueClassNumber = UniqueClassNumber;
        }
        public void PrintStudent()
        {
            Console.WriteLine($"{Name} {lastName}, UniqueClassNumber: {UniqueClassNumber} ");
        }
    }
}
