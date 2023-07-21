using System;
namespace EmployeeWageComputation1
{
	public class Employee
	{
        // Use of private variables //
		private const int FULL_TIME = 1;
        private const int PART_TIME = 2;
        private  int ratePerHour;
        private int fullDayHour = 8;
        private  int partTimeHour= 4;
        private  int totalWorkingDays;
        private  int workingHoursPerMonth;

        private string company;
        private int empHours = 0;
        //Use of method inside a class//

        public Employee(string cmp, int ratePerHour, int totalWorkingDays, int workingHoursPerMonth)
        {
            this.company = cmp;
            this.ratePerHour = ratePerHour;
            this.totalWorkingDays = totalWorkingDays;
            this.workingHoursPerMonth = workingHoursPerMonth;
        }


        public void MonthlyWage()
        {
            int totalHours = 0;
            int totalWage=0;
            int day=1;

            while (totalHours <= this.workingHoursPerMonth && day <= this.totalWorkingDays)
            {
                Random rnd = new Random();
                int rnd_num = rnd.Next(0, 3);

                switch (rnd_num)
                {

                    case PART_TIME:
                        {
                            empHours = this.partTimeHour;
                            break;
                        }

                    case FULL_TIME:
                        {
                            empHours = this.fullDayHour;
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

            totalWage = totalHours * this.ratePerHour;

            Console.WriteLine($"Total Wage for {day - 1} is {totalWage}");
        }
    }
}

