using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Discipline:OptionalComments
    {
        private string NameOfDiscipline { get; set; }
        private int NumberOfLectures { get; set; }
        private int NumberOfExercises { get; set; }


        public Discipline(string NameOfDiscipline, int NumberOfLectures, int NumberOfExercises)
        {
            this.NameOfDiscipline = NameOfDiscipline;
            this.NumberOfLectures = NumberOfLectures;
            this.NumberOfExercises = NumberOfExercises;
        }
    }
}
