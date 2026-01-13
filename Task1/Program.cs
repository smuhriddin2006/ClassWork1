Person person = new Person
{
    FirstName = System.Console.ReadLine(),
    LastName = System.Console.ReadLine(),
    Age = int.Parse(System.Console.ReadLine())
};
person.GetInfo();