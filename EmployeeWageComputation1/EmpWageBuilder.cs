using System;
namespace EmployeeWageComputation1
{
	public class EmpWageBuilder
	{
		private Company[] allCompanies;
		private int cntOfCompany = 0;

		public EmpWageBuilder()
		{
			this.allCompanies = new Company[5];
		}

		public void AddCompanyDetails(string name, int ratePerHour, int totalWorkingDays, int totalWorkingHour)
		{
			// Adding  a company object to the array//
			Company c = new Company(name, ratePerHour, totalWorkingDays, totalWorkingHour);
			allCompanies[this.cntOfCompany] = c;
			cntOfCompany++;
		}

		public void SetWageForAllCompany()
		{

			for(int i = 0; i<cntOfCompany;i++)
			{
				allCompanies[i].setTotalWage(allCompanies[i].CalculateWage());
				
			}

		}

		
	}
}

