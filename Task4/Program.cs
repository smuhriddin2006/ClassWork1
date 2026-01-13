using Task4;

Employee employee1 = new Employee();
System.Console.Write("Emp Name: ");
employee1.FirstName = System.Console.ReadLine();
System.Console.Write("Emp LastName: ");
employee1.LastName = System.Console.ReadLine();
System.Console.Write("Emp Age: ");
employee1.Age = int.Parse(System.Console.ReadLine());
System.Console.Write("Emp Postion: ");
employee1.Postiton = System.Console.ReadLine();
System.Console.Write("Emp Salary: ");
employee1.Salary = decimal.Parse(System.Console.ReadLine());
employee1.SetSalary(4);
employee1.GetInfo();
