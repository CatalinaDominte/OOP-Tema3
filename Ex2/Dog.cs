using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Dog:Animal
    {
        public override string Sound()
        {
            Console.WriteLine("The Dog does:");
            return "Ham Ham";
        }
        public Dog(string Name, int Age, string Sex) : base(Name, Age, Sex)
        {

        }
    }
}
