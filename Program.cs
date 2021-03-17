using System;

namespace Employee 
{
    class EmployeeTest
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Adedeji", "Praise", (decimal) 100000000.13);
            Employee employee2 = new Employee("Betiku", "Aderinsola", (decimal) 250000000.15);

            Console.WriteLine("Employee 1 First Name: {0}", employee1.FirstName);
            Console.WriteLine("Employee 1 Last Name: {0}", employee1.LastName);
            Console.WriteLine("Employee 1 Salary: {0:c}", employee1.Salary);

            Console.WriteLine("Employee 2 First Name: {0}", employee2.FirstName);
            Console.WriteLine("Employee 2 Last Name: {0}", employee2.LastName);
            Console.WriteLine("Employee 2 Salary: {0:c}", employee2.Salary);

            Console.WriteLine();
            Console.WriteLine("After an 10% raise in there salary");

            employee1.Salary = employee1.Salary * (decimal)1.1;
            employee2.Salary = employee2.Salary * (decimal)1.1;
            Console.WriteLine("Employee 1 new salary is : {0:c}", employee1.Salary);
            Console.WriteLine("Employee 2 new salary is : {0:c}", employee2.Salary);

            Console.ReadLine();

        }
    }
}
