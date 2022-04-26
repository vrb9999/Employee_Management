using System;

namespace emp_partime
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            int partTime = 2;
            int empWageHrs = 0;
            int empWagePrHrs = 20;
            Random random = new Random();           
            int empAttendence = random.Next(0, 3);

            if (empAttendence == fullTime)
            {
                Console.WriteLine("Full time");
                empWageHrs = 8;
            }
            else if (empAttendence == partTime)
            {
                Console.WriteLine("Part time");
                empWageHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
            int totalWage = empWagePrHrs * empWageHrs;
            Console.WriteLine("Employee total Wage: " + totalWage);
        }
    }
}
