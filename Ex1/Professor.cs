using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Professor:Person
    {
        private List<Discipline> Discipline;

        public Professor(string Name, string lastName, List<Discipline> Discipline)
            : base(Name, lastName)
        {
            this.Discipline = Discipline;
        }
    }
}
