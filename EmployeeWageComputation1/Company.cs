
using System;
namespace EmployeeWageComputation1
{
	
	public class Company
	{
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public string name;
		public int ratePerHour;
		public int totalWorkingDays;
		public int totalWorkingHour;
		public int totalWage;
        public List<int> dailyWages = new List<int>();
        
        public Company(string name, int ratePerHour, int totalWorkingDays, int totalWorkingHour)
		{
			this.name = name;
			this.ratePerHour = ratePerHour;
			this.totalWorkingDays = totalWorkingDays;
			this.totalWorkingHour = totalWorkingHour;
			this.totalWage = 0;

		}

		public void setTotalWage(int wage)
		{
			this.totalWage = wage;
		}

		public int CalculateWage()
		{
            int totalHours = 0;
            int totalWage = 0;
            int day = 1;
            int empHours = 0;

            while (totalHours <= this.totalWorkingHour && day <= this.totalWorkingDays)
            {
                Random rnd = new Random();
                int rnd_num = rnd.Next(0, 3);

                switch (rnd_num)
                {

                    case PART_TIME:
                        {
                            empHours = 4;
                            break;
                        }

                    case FULL_TIME:
                        {
                            empHours = 8;
                            break;
                        }

                    default:
                        {
                            empHours = 0;
                            break;
                        }


                }

                dailyWages.Add(empHours * this.ratePerHour);
                totalHours += empHours;
                day++;
            }

            totalWage = totalHours * this.ratePerHour;

            Console.WriteLine($"Total Wage for {day - 1} is {totalWage}");
            return totalWage;
        }

    }
	
}

