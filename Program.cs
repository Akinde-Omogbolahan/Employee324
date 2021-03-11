using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee324
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Michael", "Odubiro", 200000m);
            Employee employee2 = new Employee("Kehinde", "Atunrase", 200000m);

            Console.WriteLine("Employee1 Full Name is: {0} {1}", employee1.FirstName, employee1.LastName);
            Console.WriteLine("Employee1 Monthly Salary is: N{0}", employee1.Salary);
            employee1.Salary = employee1.Salary * 12;
            Console.WriteLine("Employee1 Yearly salary is: N{0}", employee1.Salary);

            Console.WriteLine("Employee2 Full Name is: {0} {1}", employee2.FirstName, employee2.LastName);
            Console.WriteLine("Employee2 Monthly Salary is: N{0}", employee2.Salary);
            employee2.Salary = employee2.Salary * 12;
            Console.WriteLine("Employee2 Yearly salary is: N{0}", employee2.Salary);


            Console.WriteLine();
            Console.WriteLine("After 10% raise");

            employee1.Salary = employee1.Salary * 1.1m;
            employee2.Salary = employee2.Salary * 1.1m;

            Console.WriteLine("Employee1 new Salary is: N{0}", employee1.Salary);
            Console.WriteLine("Employee2 new Salary is: N{0}", employee2.Salary);


            Console.ReadKey();
        }
    }
}
