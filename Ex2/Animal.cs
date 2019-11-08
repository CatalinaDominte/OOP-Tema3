using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    abstract class Animal:ISound
    {
       
        public abstract string Sound();

        protected string Name { get; set; }
        protected int Age { get; set; }
        protected string Sex { get; set; }

        protected Animal(string Name, int Age, string Sex)
        {
            this.Name = Name;
            this.Age = Age;
           this.Sex = Sex;
            

        }
        public static double CalculateAvarage(Animal [] animal)
        {
            var avgAge = animal.Average(s => s.Age);
            
                return avgAge;
            
        }

    }

}
