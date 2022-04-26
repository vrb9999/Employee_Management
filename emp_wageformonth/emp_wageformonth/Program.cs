using System;

namespace emp_wageformonth
{
    class Program
    {
        static void Main(string[] args)
        {
            int empWageHrs = 0;
            int empWagePrHrs = 20;
            int empWorkPrMonth = 20;
            Random random = new Random();
            int empAttendence = random.Next(0, 3);

            switch (empAttendence)
            {
                case 0:
                    Console.WriteLine("Employee is not Present");
                    break;
                case 1:
                    Console.WriteLine("Employee is FullTime");
                    empWageHrs = 8;
                    break;
                case 2:
                    Console.WriteLine("Employee is PartTime");
                    empWageHrs = 4;
                    break;
            }
            int totalWage = empWorkPrMonth * empWagePrHrs * empWageHrs;
            Console.WriteLine("Employee total Wage for Month: " + totalWage);
        }
    }
}
