using System;
using System.Collections.Generic;

class Program
{
    // Function to calculate total pay
    static double CalculatePay(int hoursPerDay, int daysWorked, double hourlyWage)
    {
        return hoursPerDay * daysWorked * hourlyWage;
    }

    static void Main()
    {
        // VARIABLES, INPUT, OUTPUT
        Console.WriteLine("=== Employee Wage Calculator ===");
        Console.Write("Enter number of employees: ");
        int employeeCount = int.Parse(Console.ReadLine());

        // LIST to store employee names
        List<string> employeeNames = new List<string>();
        List<double> employeePays = new List<double>();

        // LOOP through each employee
        for (int i = 0; i < employeeCount; i++)
        {
            Console.WriteLine($"\n--- Employee {i + 1} ---");

            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            employeeNames.Add(name);

            Console.Write("Enter hours worked per day: ");
            int hoursPerDay = int.Parse(Console.ReadLine());

            Console.Write("Enter number of days worked: ");
            int daysWorked = int.Parse(Console.ReadLine());

            Console.Write("Enter hourly wage: ");
            double hourlyWage = double.Parse(Console.ReadLine());

            // CONDITIONALS: check if employee worked overtime (>8 hours/day)
            if (hoursPerDay > 8)
            {
                Console.WriteLine("Overtime detected! Extra pay will be added.");
                hourlyWage *= 1.25; // 25% bonus for overtime
            }

            // FUNCTIONS: calculate pay using a function
            double totalPay = CalculatePay(hoursPerDay, daysWorked, hourlyWage);
            employeePays.Add(totalPay);

            // OUTPUT
            Console.WriteLine($"Employee: {name}");
            Console.WriteLine($"Total Pay: ${totalPay:F2}");
        }

        // FINAL SUMMARY
        Console.WriteLine("\n=== Payroll Summary ===");
        for (int i = 0; i < employeeNames.Count; i++)
        {
            Console.WriteLine($"{employeeNames[i]} earned ${employeePays[i]:F2}");
        }
    }
}
