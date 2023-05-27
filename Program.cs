using System;

namespace Operators_Assign
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate two Employee objects and assign values to their properties
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };

            // Compare the two Employee objects using the overloaded operators
            bool areEqual = emp1 == emp2;

            // Display the result of the comparison
            Console.WriteLine($"Are the employees equal? {areEqual}");

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}
