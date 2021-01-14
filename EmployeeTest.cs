using System;

class EmployeeTest
{
    static void Main()
    {
        



        Employee employee1 = new Employee();
        Employee employee2 = new Employee();


        
        Console.Write($"Please enter the first employee's first name: ");
        string theFirstName = Console.ReadLine();
        employee1.SetFirstName(theFirstName);

        Console.Write($"Please enter the first employee's last name: ");
        string theLastName = Console.ReadLine();
        employee1.SetLastName(theLastName);

        Console.Write($"Please enter the first employee's mothly salary: ");
        decimal theMonthlySalary = decimal.Parse(Console.ReadLine());
        employee1.SetMonthlySalary(theMonthlySalary);

        Console.Write($"Please enter the second employee's first name: ");
        string theSecondFirstName = Console.ReadLine();
        employee2.SetFirstName(theSecondFirstName);

        Console.Write($"Please enter the second employee's last name: ");
        string theSecondLastName = Console.ReadLine();
        employee2.SetLastName(theLastName);

        Console.Write($"Please enter the second employee's mothly salary: ");
        decimal theSecondMonthlySalary = decimal.Parse(Console.ReadLine());
        employee2.SetMonthlySalary(theSecondMonthlySalary);


        Console.WriteLine($"\nThe first employee's name: {employee1.GetFirstName()} {employee1.GetLastName()}; his/her mothly salary is: {employee1.GetMonthlySalary()}.");
        Console.WriteLine($"The annual salary of {employee1.GetFirstName()}'s is {employee1.GetMonthlySalary() * 12}.");
        Console.WriteLine($"{employee1.GetFirstName()}'s annual salary for next year(after 10% increment) is {(employee1.GetMonthlySalary() * 12) + ((employee1.GetMonthlySalary() * 12) / 10)}");


        Console.WriteLine($"\nThe second employee's name: {employee2.GetFirstName()} {employee2.GetLastName()}; his/her mothly salary is {employee2.GetMonthlySalary()}.");
        Console.WriteLine($"The annual salary of {employee2.GetFirstName()}'s is {employee2.GetMonthlySalary() * 12}.");
        Console.WriteLine($"{employee2.GetFirstName()}'s annual salary for next year(after 10% increment) is {(employee2.GetMonthlySalary() * 12) + ((employee2.GetMonthlySalary() * 12) / 10)}");

    }
}
  