using System;
namespace EmployeeWageComputation1
{
	public class Employee
	{
		public const int IS_PRESENT = 1;
        public const int PART_TIME = 2;
        public const int RATE_PER_HOUR = 20;
		public const int FULL_DAY_HOUR = 8;
        public const int PART_TIME_HOUR = 4;

        public void PartTime()
		{
			Random rnd = new Random();
			int num = rnd.Next(0, 3);
			int dailyWage = 0;
			if(num == IS_PRESENT)
			{
				dailyWage = RATE_PER_HOUR * FULL_DAY_HOUR;
				Console.WriteLine($"DailyWage of Employee is {dailyWage} ");
			}
			else if(num == PART_TIME)
			{
                dailyWage =  RATE_PER_HOUR* PART_TIME_HOUR;
                Console.WriteLine($"DailyWage of Employee is {dailyWage}");
            }

			else
			{
                Console.WriteLine($"DailyWage of Employee is {dailyWage}");
            }

		}
	}
}

