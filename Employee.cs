using System;

class Employee
{
    public string firstName;

    public string lastName;

    public decimal monthlySalary;

    

    


    
    public void SetFirstName(string employeeFirstName)
    {
        firstName = employeeFirstName;
    }

    public string GetFirstName()
    {
        return firstName;
    }

    public void SetLastName(string employeeLastName)
    {
        lastName = employeeLastName;
    }

    public string GetLastName()
    {
        return lastName;
    }

    public void SetMonthlySalary(decimal employeeMonthlySalary)
    {
        monthlySalary = employeeMonthlySalary;
        while (monthlySalary < 0)
        {
            Console.WriteLine("Monthly salary should be positive number!");
            break;
        }
        
               
    }

    public decimal GetMonthlySalary()
    {
        return monthlySalary;
    }

    

}
