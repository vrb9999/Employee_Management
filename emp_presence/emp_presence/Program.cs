using System;

namespace emp_presence
{
    class Program
    {
        static void Main(string[] args)
        {
            int is_full_time = 1;
            Random obj = new Random();
            int emp_check = obj.Next(0, 2);
            if (emp_check == is_full_time)
            {
                Console.WriteLine("Emp is present");
            }

            else
            {
                Console.WriteLine("Emp is absent");
            }
        }
    }
}