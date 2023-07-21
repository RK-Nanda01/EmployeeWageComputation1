using System;
namespace EmployeeWageComputation1
{
	public class EmpWageBuilder
	{
		private Company[] allCompanies;
		private Dictionary<string, Company> CompanyEmpWage;
		private int cntOfCompany = 0;

		public EmpWageBuilder()
		{
			this.allCompanies = new Company[5];
			this.CompanyEmpWage = new Dictionary<string, Company>();

        }

		public void AddCompanyDetails(string name, int ratePerHour, int totalWorkingDays, int totalWorkingHour)
		{
			// Adding  a company object to the array//
			Company c = new Company(name, ratePerHour, totalWorkingDays, totalWorkingHour);
			allCompanies[this.cntOfCompany] = c;
			CompanyEmpWage.Add(name, c);
			cntOfCompany++;
		}

		public void SetWageForAllCompany()
		{

			for(int i = 0; i<cntOfCompany;i++)
			{
				allCompanies[i].setTotalWage(allCompanies[i].CalculateWage());
				
			}

		}

		public void GetDeatilByName(string name)
		{
			Console.WriteLine($"Total wage of company {name} is {CompanyEmpWage[name].totalWage}");
		}

		
	}
}

