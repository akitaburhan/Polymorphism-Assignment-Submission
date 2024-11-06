namespace EmployeeApp
{
    public class Employee : Person, IQuittable
    {
        // Property for employee ID
        public int Id { get; set; }

        // Implementation of the Quit method from IQuittable
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} has quit the job.");
        }
    }
}