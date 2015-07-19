using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomOrderBy.WithIComparer
{
    class Program
    {
        //In this example i need to sort a collection of employee by hierarchical code splited by '.'
        //so i use an EmployeeAscendingHierachicalComparer class  wich implements IComparer<T> interface
        //and  i pass an instance of to Sort method of List<T>
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee{Code = "1",Name = "Joe"},
                new Employee{Code = "1.1.1",Name = "Joe"},
                new Employee{Code = "1.1",Name = "Joe"},
                new Employee{Code = "1.1.2",Name = "Joe"},
                new Employee{Code = "1.2.2",Name = "Joe"},
                new Employee{Code = "1.2",Name = "Joe"},
                new Employee{Code = "2",Name = "Joe"},
                new Employee{Code = "3",Name = "Joe"},
                new Employee{Code = "3.1",Name = "Joe"},
                new Employee{Code = "3.3",Name = "Joe"},
                new Employee{Code = "2.1",Name = "Joe"},
                new Employee{Code = "2.1.3",Name = "Joe"},
                new Employee{Code = "2.1.3.1",Name = "Joe"},
                new Employee{Code = "3.2",Name = "Joe"},
                new Employee{Code = "3.2.1",Name = "Joe"},
                new Employee{Code = "3.1.1",Name = "Joe"},
                new Employee{Code = "3.1.4",Name = "Joe"},
                new Employee{Code = "1.1.2.3",Name = "Joe"},
                new Employee{Code = "1.1.2.1",Name = "Joe"},
            };

            Console.WriteLine("** Employees **");
            Console.WriteLine();
            employees.ForEach(Console.WriteLine);
            Console.WriteLine();
            Console.WriteLine("** Employees ** Ordered");
            Console.WriteLine();
            employees.Sort(new EmployeeAscendingHierachicalComparer());
            employees.ForEach(Console.WriteLine);
            Console.ReadKey();
        }
    }
}
