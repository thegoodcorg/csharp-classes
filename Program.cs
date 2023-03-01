using System;
using Classes.Employees;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company foodNStuff = new Company("Food N' Stuff", DateTime.Now);

            // Create three employees
            var employee1 = new Employee
            {
                FirstName = "Oscar",
                LastName = "Grouch",
                Title = "CEO",
                StartDate = DateTime.Now
            }; 
            var employee2 = new Employee
            {
                FirstName = "Homey",
                LastName = "Clown",
                Title = "COO",
                StartDate = DateTime.Now
            }; 
            var employee3 = new Employee
            {
                FirstName = "Vash",
                LastName = "Stampeed",
                Title = "CFO",
                StartDate = DateTime.Now
            };
            Employee employee4 = new Employee("Ricky");

            employee4.LastName = "Bruner";
            
            Employee employee5 = new Employee("Jeremy", "Not CEO");
            // Assign the employees to the company
            foodNStuff.Employees.Add(employee1);
            foodNStuff.Employees.Add(employee2);
            foodNStuff.Employees.Add(employee3);
            foodNStuff.Employees.Add(employee4);
            foodNStuff.Employees.Add(employee5);

            

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foodNStuff.ListEmployees();
        }
    }
}