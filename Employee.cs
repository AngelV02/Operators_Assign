using System;
using System.Collections.Generic;
using System.Text;

namespace Operators_Assign
{
    public class Employee
    {
        // Employee properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Overloading the "==" operator to compare Employee objects based on their Id
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            if (ReferenceEquals(emp1, emp2))
                return true;

            if (emp1 is null || emp2 is null)
                return false;

            return emp1.Id == emp2.Id;
        }

        // Overloading the "!=" operator to compare Employee objects based on their Id
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }
    }
}
