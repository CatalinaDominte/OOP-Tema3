using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student("Balanovici", "Andrei", 7);
            Student1.PrintStudent();
            Student1.AddComment("Este un elev dificil");

            Student Student2 = new Student("Deleanu", "Cristina", 10);
            Student2.PrintStudent();
            Student1.AddComment("Este un elev bun");

            Discipline Chemistry = new Discipline("Chimie", 5, 7);
            Professor Professor1 = new Professor("Iancu", "Gabriel", new List<Discipline>() { Chemistry });

            Professor1.AddComment("Este un profesor genial");
            Class ClasaVI = new Class(new List<Student>() { Student1, Student2 }, new List<Professor>() { Professor1 }, "ID 7");
            Console.ReadLine();
        }
        
    }
}
