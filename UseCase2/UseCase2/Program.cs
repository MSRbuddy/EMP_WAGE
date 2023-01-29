using System;

namespace UseCase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            int WAGE_PER_HOUR = 20;
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int number = random.Next(0, 2);
            if(number==FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Emplyee Daily Wage is: ");
        }
    }
}
