namespace EmployeeApp
{
    public class Person
    {
        // Properties for first and last names
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Method to display the full name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}