using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Employee
    {
        private int EmpWages { get; }
        private int WorkingHour { get; }

        public Employee(int empWages, int workingHour)
        {
            this.EmpWages = empWages;
            this.WorkingHour = workingHour;
        }

        public void EmployeeAttendance()
        {
            Random r = new Random();
            int attendance = r.Next(0, 2);
            if(attendance == 0)
            {
                Console.WriteLine("Employee is absent");
            }
            else
            {
                Console.WriteLine("Employee is present");
            }
        }
        public int CalculateDailyWages()
        {
            return EmpWages * WorkingHour;
        }

        public int AddPartTimeWages()
        {
            
            return EmpWages * (8+8);
        }

        public int CalculateMonthlyWages()
        {
            int workingDaysPerMonth = 20;
            return workingDaysPerMonth * CalculateDailyWages();
        }

        public int CalculateWagesTillCondition()
        {
            int maxHours = 100;
            int maxDays = 20;

            int totalHours = 0, totalDays = 0, totalWages = 0;

            while (totalHours < maxHours && totalDays < maxDays)
            {
                totalHours += WorkingHour;
                totalDays++;
                totalWages += CalculateDailyWages();
            }

            return totalWages;
        }
    }
}
