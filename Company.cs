using System;
using System.Collections.Generic;

namespace ListOfEmployees
{
    public class Company
    {
        public int DateFounded { get; set; }
        private string CompanyName { get; set; }
        public List<Employee> EmployeeList { get; set; }

        public Company(string companyName, int dateFounded)
        {
            CompanyName = companyName;
            DateFounded = dateFounded;
            EmployeeList = new List<Employee>();
        }

        public void ListEmployees()
        {
            foreach (Employee employee in EmployeeList)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} is the {employee.Title} for {CompanyName} since {employee.StartDate}!");
            }
        }

    }
}