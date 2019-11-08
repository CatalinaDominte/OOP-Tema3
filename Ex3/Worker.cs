using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Worker:Human
    {
        public double weekSalary { get; set; }
        public double workHoursPerDay { get; set; }

        
        public Worker(string Name, string LastName, double WeekSalary, double WorkHoursPerDay): base(Name, LastName)
        {
            this.weekSalary = WeekSalary;
            this.workHoursPerDay = WorkHoursPerDay;
           
        }

        public double MoneyPerHour()
        {
            Console.WriteLine((weekSalary / 5) / workHoursPerDay);
            return (this.weekSalary / 5) / workHoursPerDay;
            
        }
       
    }
}
