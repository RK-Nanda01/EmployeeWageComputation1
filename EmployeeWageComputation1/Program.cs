namespace EmployeeWageComputation1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Employee Wage Computation!");
        Employee e = new Employee("Deloitte", 20, 20, 100);
        Employee f = new Employee("Google", 30, 20, 100);
        e.MonthlyWage();
        f.MonthlyWage();
        Console.ReadLine();

    }
}

