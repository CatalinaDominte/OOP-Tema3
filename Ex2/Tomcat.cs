using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Tomcat:Cats
    {
        //private const string Sex = "Male";
        protected Tomcat(string Name, int Age, string Sex) : base(Name, Age, Sex)
        {

        }
    }
}
