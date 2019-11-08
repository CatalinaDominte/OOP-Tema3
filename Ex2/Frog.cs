using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Frog:Animal
    {
        public override string Sound()
        {
            Console.WriteLine("The Frog does:");
            return "Oac Oac";
        }
        public Frog(string Name, int Age, string Sex) : base(Name, Age, Sex)
        {

        }
    }
}
