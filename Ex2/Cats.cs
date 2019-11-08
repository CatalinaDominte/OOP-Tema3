using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Cats:Animal
    {
        public override string Sound()
        {
            Console.WriteLine("The cat does:");
            return "Miau Miau";
        }

        public Cats(string Name, int Age, string Sex) : base(Name, Age, Sex)
        {

        }
    }
}
