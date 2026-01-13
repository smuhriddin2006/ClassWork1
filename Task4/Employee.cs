using System.Dynamic;

namespace Task4;

public class Employee
{
    public string FirstName {get; set;}=string.Empty;
    public string LastName {get; set;}=string.Empty;
    public int Age {get; set;}
    public string Postiton {get; set;}=string.Empty;
    public decimal Salary {get; set;}

    public void SetSalary(decimal salary)
    {
        Salary+=salary;
    }

    public decimal GetSalary()
    {
        return Salary;
    }
    public void GetInfo()
    {
        System.Console.WriteLine($"Name: {FirstName} - LastName: {LastName} - Age: {Age} - Salary {Salary}");
    }

}
