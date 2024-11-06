using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an Employee instance and initialize the name properties
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 1
            };

            // Use polymorphism to create an IQuittable object
            IQuittable quittableEmployee = employee;

            // Call the Quit method on the IQuittable object
            quittableEmployee.Quit();
        }
    }
}