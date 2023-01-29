using System;

namespace UseCase4
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
            switch(number)
            {
                case 0: PART_TIME:
                    empHrs = 4;
                    break;
                case 1: FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * WAGE_PER_HOUR;
            Console.WriteLine("Employee Daily Wage using switch case is: ");
        }
    }
}
