using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace EmployeePayrollSystem
{
    public class PayrollSystem
    {
        private List<Employee> employees = new List<Employee>();

        public void Run()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Display All Employees");
                Console.WriteLine("3. Exit");
                Console.Write("Select an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddEmployee();
                        break;
                    case "2":
                        DisplayEmployees();
                        break;
                    case "3":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        private void AddEmployee()
        {
            Employee employee = new Employee();
            Console.Write("Enter Employee ID: ");
            employee.EmployeeID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            employee.Name = Console.ReadLine();

            Console.Write("Enter Basic Salary: ");
            employee.BasicSalary = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter HRA: ");
            employee.HRA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter DA: ");
            employee.DA = Convert.ToDouble(Console.ReadLine());

            employee.CalculateNetSalary();
            employees.Add(employee);

            Console.WriteLine("Employee added successfully!\n");
        }

        private void DisplayEmployees()
        {
            Console.WriteLine("\nEmployee Details:");
            foreach (var emp in employees)
            {
                emp.Display();
            }
            Console.WriteLine();
        }
    }
}
