using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    abstract class Person:OptionalComments
    {
        protected string Name { get; set; }
        protected string lastName { get; set; }

        protected Person(string Name, string lastName)
        {
            this.Name = Name;
            this.lastName = lastName;
        }
    }
}
