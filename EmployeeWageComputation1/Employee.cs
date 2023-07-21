using System;
namespace EmployeeWageComputation1
{
	public class Employee
	{
		public const int IS_PRESENT = 1;
		public const int RATE_PER_HOUR = 20;
		public const int FULL_DAY_HOUR = 8;

		public void DailyWage()
		{
			Random rnd = new Random();
			int num = rnd.Next(0, 2);
			int dailyWage = 0;
			if(num == IS_PRESENT)
			{
				dailyWage = RATE_PER_HOUR * FULL_DAY_HOUR;
				Console.WriteLine($"DailyWage of Employee is {dailyWage} ");
			}
			else
			{
                Console.WriteLine($"DailyWage of Employee is {dailyWage}");
            }

		}
	}
}

