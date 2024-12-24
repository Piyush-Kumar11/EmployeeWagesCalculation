using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Employee Wages:");
            int wages = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee working hour:");
            int hour = Convert.ToInt32(Console.ReadLine());

            Employee e = new Employee(wages, hour);

            char c;
            do
            {
                Console.WriteLine("Choose option:\n1.Check Employee Attendance\n2.Calculate Daily Wages\n3.Add Part time wages\n4.Wages for a Month\n5.Calculate Wages on condition");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        e.EmployeeAttendance();
                        break;

                    case 2:
                        Console.WriteLine("Daily Wages: " + e.CalculateDailyWages());
                        break;

                    case 3:
                        Console.WriteLine("Part-Time Wages: " + e.AddPartTimeWages());
                        break;

                    case 4:
                        Console.WriteLine("Monthly Wages: " + e.CalculateMonthlyWages());
                        break;

                    case 5:
                        Console.WriteLine("Wages till condition: " + e.CalculateWagesTillCondition());
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
                Console.WriteLine("Enter 'y' to continue or other key to exit!");
                c = Convert.ToChar(Console.ReadLine());
            } while (c == 'y');
            Console.WriteLine("Exited Successfully!!!");
        }
    }
}
