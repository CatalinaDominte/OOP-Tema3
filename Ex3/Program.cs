using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student("Petrescu", "Maria", 7.5);
            var student2 = new Student("Alexa", "Ana", 9.3);
            var student3 = new Student("Rina", "Ioan", 5.9);

            var worker1 = new Worker("Costin", "Mihai", 7000, 8);
            var worker2 = new Worker("Grigoriu", "Elena", 8500, 8);
            var worker3 = new Worker("Dacu", "Cristi", 6000, 8);

            worker2.MoneyPerHour();

            var task = new Tasks();
            task.AddStudent(student1);
            task.AddStudent(student2);
            task.AddStudent(student3);

            task.AddWorker(worker1);
            task.AddWorker(worker2);
            task.AddWorker(worker3);

            task.SortingStudents();
            task.SortingWorkes();
            task.AddToJoinList();
            task.SortingHumansByName();
            task.SortingHumansByLastName();
            Console.ReadLine();
        }
        
    }
}
