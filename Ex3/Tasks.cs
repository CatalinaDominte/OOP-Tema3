using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Tasks
    {
        private List<Student> StudentsList { get; set; }
        private List<Worker> WorkersList { get; set; }
        public List<Human> JoinList { get; set; }

        public Tasks()
        {
            this.StudentsList = new List<Student>();
            this.WorkersList = new List<Worker>();
            this.JoinList = new List<Human>();
        }

        public void AddToJoinList()
        {
            foreach (var item in StudentsList)
            {
                JoinList.Add(item);
            }
            foreach (var item in WorkersList)
            {
                JoinList.Add(item);
            }
            
            foreach (var item in JoinList)
            {
                Console.WriteLine($"{ item.lastName} {item.lastName}");
            }
            
        }
        public void AddStudent(Student x)
        {
            StudentsList.Add(x);
        }

        public void AddWorker(Worker x)
        {
            WorkersList.Add(x);
        }

        public void SortingStudents()

        /*var studentsInDescOrder = StudentsList.OrderByDescending(s => s.grade);
        foreach (var item in studentsInDescOrder)
        {
            Console.WriteLine($"{item.grade}- {item.name}");
        }*/

        {
            var orderByGrade = from s in StudentsList
                                orderby s.grade
                                select s;

            Console.WriteLine("Ascending Order:");


            foreach (var std in orderByGrade)
            {
                Console.WriteLine($"{std.grade}- {std.name} {std.lastName}");
            }
        }
        public void SortingWorkes()
        {
            var orderBySalary = from w in WorkersList
                                orderby ((w.weekSalary / 5) / w.workHoursPerDay) descending
                                select w;
            Console.WriteLine("Descending Order:");

            foreach (var wrk in orderBySalary)
            {
                Console.WriteLine($"{((wrk.weekSalary / 5) / wrk.workHoursPerDay)}- {wrk.name} {wrk.lastName}");
            }
        }
        public void SortingHumansByName()
        {
            var orderByName = from h in JoinList
                              orderby h.name
                              select h;
            Console.WriteLine("Sorting by names: ");
            foreach (var item in orderByName)
            {
                Console.WriteLine($" {item.name} {item.lastName}");
            }
        }
        public void SortingHumansByLastName()
        {
            var orderByLastName = from h in JoinList
                                  orderby h.lastName
                                  select h;
            Console.WriteLine("Sorting by last name: ");

            foreach (var item in orderByLastName)
            {
                Console.WriteLine($" {item.name} {item.lastName}");
            }
        }
    }
}

