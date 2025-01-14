using System;

public enum EmployeeRole
{
    Manager,   
    Developer, 
    Designer,   
    Tester      
}

public class SalaryCalculator
{
    
    public decimal Hesapla(EmployeeRole role)
    {
        decimal salary;

        switch (role)
        {
            case EmployeeRole.Manager:
                salary = 8000m; 
                break;
            case EmployeeRole.Developer:
                salary = 6000m; 
                break;
            case EmployeeRole.Designer:
                salary = 5000m; 
                break;
            case EmployeeRole.Tester:
                salary = 4000m; 
                break;
            default:
                salary = 0m; 
                break;
        }

        return salary;
    }
}

class Program
{
    static void Main()
    {
        SalaryCalculator salaryCalculator = new SalaryCalculator();

        
        Console.WriteLine("Yönetici maaşı: " + salaryCalculator.Hesapla(EmployeeRole.Manager));
        Console.WriteLine("Geliştirici maaşı: " + salaryCalculator.Hesapla(EmployeeRole.Developer));
        Console.WriteLine("Tasarımcı maaşı: " + salaryCalculator.Hesapla(EmployeeRole.Designer));
        Console.WriteLine("Test Uzmanı maaşı: " + salaryCalculator.Hesapla(EmployeeRole.Tester));
    }
}
