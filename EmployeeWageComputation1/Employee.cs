using System;
namespace EmployeeWageComputation1
{
	public class Employee
	{
        // Use of private variables //
		private const int FULL_TIME = 1;
        private const int PART_TIME = 2;
        private const int RATE_PER_HOUR = 20;
		private const int FULL_DAY_HOUR = 8;
        private const int PART_TIME_HOUR = 4;
        private const int TOTAL_WORKING_DAY = 20;
        private const int TOTAL_WORKING_HOURS = 100;
        private int empHours = 0;
        //Use of method inside a class//
        public void MonthlyWage()
        {
            int totalHours = 0;
            int totalWage=0;
            int day=1;

            while (totalHours <= TOTAL_WORKING_HOURS && day <= TOTAL_WORKING_DAY)
            {
                Random rnd = new Random();
                int rnd_num = rnd.Next(0, 3);

                switch (rnd_num)
                {

                    case PART_TIME:
                        {
                            empHours = PART_TIME_HOUR;
                            break;
                        }

                    case FULL_TIME:
                        {
                            empHours = FULL_DAY_HOUR;
                            break;
                        }

                    default:
                        {
                            empHours = 0;
                            break;
                        }


                }

                totalHours += empHours;
                day++;
            }

            totalWage = totalHours * RATE_PER_HOUR;

            Console.WriteLine($"Total Wage for {day - 1} is {totalWage}");
        }
    }
}

