using System;
using System.IO;
using System.Collections.Generic;

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string ContractType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int DaysRemaining { get { return (int)(EndDate - DateTime.Now).TotalDays; } }
}

public class EmployeeContractRecord
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();

        // Replace this with the path to your CSV file
        string filePath = "employee_records.csv";

        // Open the file for reading
        using (StreamReader reader = new StreamReader(filePath))
        {
            // Read the header line
            string headerLine = reader.ReadLine();

            // Split the header line into fields
            string[] fields = headerLine.Split(',');

            // Read the data lines
            while (!reader.EndOfStream)
            {
                string dataLine = reader.ReadLine();

                // Split the data line into fields
                string[] values = dataLine.Split(',');

                // Create a new Employee object and populate its properties
                Employee employee = new Employee();

                employee.ID = int.Parse(values[0]);
                employee.Name = values[1];
                employee.ContractType = values[2];
                employee.StartDate = DateTime.Parse(values[3]);
                employee.EndDate = DateTime.Parse(values[4]);
                employee.Department = values[5];

                // Add the new Employee object to the list of employees
                employees.Add(employee);
            }
        }

        employees = employees.OrderBy(e => e.DaysRemaining).ToList();

        Console.WriteLine("  ID   |    Name     |  Contract Type |\t\tStart\t       |\t  End\t  |  Department  |   Remaining Days    |");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");

        // Do something with the list of employees, such as displaying them on the console
        foreach (Employee employee in employees)
        {
            var warning = "";
            if (employee.DaysRemaining <= 60 && employee.DaysRemaining > 0)
            {
                warning = "!!! Exp Date near !!!";
            }
            
            if (employee.DaysRemaining > 0)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t\t{3}\t\t{4}\t{5}\t\t{6} days \t{7}",
                employee.ID,
                employee.Name,
                employee.ContractType,
                employee.StartDate.ToShortDateString(),
                employee.EndDate.ToShortDateString(),
                employee.Department,
                employee.DaysRemaining,
                warning);
                Console.WriteLine();
            }
            
        }

        // Wait for the user to press a key before exiting
        Console.ReadKey();
    }
}
