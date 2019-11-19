using System;
using System.Collections.Generic;

namespace ListOfEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Nick = new Employee()
            {
                FirstName = "Nick",
                LastName = "Wessel",
                Title = "CEO",
            };
            Employee Mark = new Employee()
            {
                FirstName = "Marky",
                LastName = "Mark",
                Title = "President",
            };
            Employee David = new Employee()
            {
                FirstName = "David Daniel",
                LastName = "Patrick",
                Title = "Co-Founder",
            };

            Company NSS = new Company("NSS", 10 - 23 - 19);

            NSS.EmployeeList.Add(Nick);
            NSS.EmployeeList.Add(David);
            NSS.EmployeeList.Add(Mark);
            NSS.ListEmployees();
        }
    }
}