using System;

namespace Classes.Employees
{

    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
    
        public Employee(string firstName)
        {
            FirstName = firstName;
            Title = "CEO";
        }
       public Employee(string firstName, string title)
        {
            FirstName = firstName;
            Title = title;
        }
        public Employee()
        {
            
        }
    }
}
