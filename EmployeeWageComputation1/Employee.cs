using System;
namespace EmployeeWageComputation1
{
	public class Employee
	{
		public const int IS_PRESENT = 1;

		public void IsPresent()
		{
			Random rnd = new Random();
			int num = rnd.Next(0, 2);

			if(num == IS_PRESENT)
			{
				Console.WriteLine("The Employee Is Present");
			}
			else
			{
				Console.WriteLine("The Employee is Absent");
			}

		}
	}
}

