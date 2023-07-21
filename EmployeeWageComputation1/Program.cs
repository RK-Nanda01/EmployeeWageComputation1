namespace EmployeeWageComputation1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Wage Computation!");
        EmpWageBuilder e = new EmpWageBuilder();
        e.AddCompanyDetails("Deloitte", 20, 20, 100);
        e.AddCompanyDetails("Google", 30, 20, 100);
        e.AddCompanyDetails("Zudio", 40, 20, 100);
        e.SetWageForAllCompany();


        Console.ReadLine();

    }
}

