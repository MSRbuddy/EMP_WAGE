using System;

namespace UseCase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PART_TIME = 1;
            int FULL_TIME = 2;
            int WAGE_PER_HOUR = 20;
            
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            int number = random.Next(0, 3);
            if(number==PART_TIME)
            {
                empHrs = 4;
            }
            else if (number==FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage is: ");
        }
    }
}
