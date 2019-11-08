using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Class:OptionalComments
    {
        
        private List<Student> Students;
        private List<Professor> Professors;
        private string ClassID;

        public Class(List<Student> Students, List<Professor> Professors, string ClassID)
        {
            this.Students = Students;
            this.Professors = Professors;
            this.ClassID = ClassID;

        }
    }
}
