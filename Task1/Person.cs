public class Person
{
    public string FirstName {get; set;}=string.Empty;
    public string LastName {get; set;}=string.Empty;
    public int Age {get; set;}

    public void GetInfo()
    {
        System.Console.WriteLine($"FirstName: {FirstName} - LastName: {LastName} - Age {Age}");
    }
}