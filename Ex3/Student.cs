using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Student:Human
    {
        public double grade { get; set; }
        
        public Student(string Name, string LastName, double Grade) : base(Name, LastName)
        {
            this.grade = Grade;
            
        }
       
       
    }
}
