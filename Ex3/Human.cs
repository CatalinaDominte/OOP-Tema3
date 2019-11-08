using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    public abstract class Human
    {
        public string name { get; set; }
        public string lastName { get; set; }


        protected Human(string Name, string LastName)
        {
            this.name = Name;
            this.lastName = LastName;
           
        }

        
        
    }
     
    
    
}
