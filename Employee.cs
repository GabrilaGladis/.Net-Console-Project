using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EmployeePayrollSystem
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double BasicSalary { get; set; }
        public double HRA { get; set; }
        public double DA { get; set; }
        public double Tax { get; set; }
        public double NetSalary { get; set; }

        public void CalculateNetSalary()
        {
            double grossSalary = BasicSalary + HRA + DA;
            Tax = grossSalary * 0.1;  // Assume 10% tax
            NetSalary = grossSalary - Tax;
        }

        public void Display()
        {
            // Display the Net Salary with currency format
            System.Console.WriteLine("ID: {0}, Name: {1}, Net Salary: {2:C}", EmployeeID, Name, NetSalary);
        }
    }
}
