using System;

namespace emp_presence
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_full_time = 1;
            int per_hr = 20;
            int empWage = 0;
            int empHr = 0;
            Random obj = new Random();
            int emp_check = obj.Next(0,2);
            if (emp_check == is_full_time) {
                Console.WriteLine("Emp is present");
                empHr = 8;
            }

            else
            {
                Console.WriteLine("Emp is absent");
                empHr = 0;
            }
            empWage = empHr * per_hr;
            Console.WriteLine("Employee wage is : " + empWage);
        }
    }
}