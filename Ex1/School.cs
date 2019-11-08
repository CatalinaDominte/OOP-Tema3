using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class School
    {
        private string Name { get; set; }
        private List<Class> Classes { get; set; }

       
        public School(List<Class> Classes, string Name)
        {
            this.Classes = Classes;
            this.Name = Name;
        }
    }
}
