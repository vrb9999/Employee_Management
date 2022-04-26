using System;

namespace emp_switchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int empWageHrs = 0;
            int empWagePrHrs = 20;
            Random random = new Random();
            int empAttendence = random.Next(0, 3);

            switch (empAttendence)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is FullTime");
                    empWageHrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is PartTime");
                    empWageHrs = 4;
                    break;
                default:
                    break;
            }
            int totalWage = empWagePrHrs * empWageHrs;
            Console.WriteLine("Employee total Wage: " + totalWage);
        }
    }
}
