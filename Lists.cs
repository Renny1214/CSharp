using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Hash
{

    public class Employee
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public double Salary { get; set; }
    }
    class Lists
    {
        public static void List()
        {
            Employee emp1 = new Employee
            {
                ID = 101,
                Name = "a",
                Salary = 3000
            };
            Employee emp2 = new Employee
            {
                ID = 102,
                Name = "b",
                Salary = 4000
            };
            Employee emp3 = new Employee
            {
                ID = 103,
                Name = "c",
                Salary = 5000
            };

            List<Employee> employees = new List<Employee>();  //empty list
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);


            foreach (Employee emp in employees)
            {
                Console.WriteLine("id is {0} , Nmae is {1} , Salary is {2}", emp.ID, emp.Name, emp.Salary);
            }
            Console.ReadLine();


            //(insert the emp3 at index 0)
            employees.Insert(0, emp3);

            foreach (Employee emp in employees)
            {
                Console.WriteLine("id is {0} , Nmae is {1} , Salary is {2}", emp.ID, emp.Name, emp.Salary);
            }
            Console.ReadLine();


            //gives a condition
            List<Employee> elist = employees.Where(x => x.Salary > 4000).ToList();
            foreach (Employee emp in elist)
            {
                Console.WriteLine("id is {0} , Nmae is {1} , Salary is {2}", emp.ID, emp.Name, emp.Salary);
            }
            Console.ReadLine();


            //for a single return value
            Employee empSingle = employees.Where(x => x.Name == "a").FirstOrDefault();
            Console.WriteLine("id is {0} , Nmae is {1} , Salary is {2}", empSingle.ID, empSingle.Name, empSingle.Salary);


            //order the list by name
            List<Employee> orderList = employees.OrderBy(x => x.Name).ToList();
            foreach (Employee emp in orderList)
            {
                Console.WriteLine("id is {0} , Nmae is {1} , Salary is {2}", emp.ID, emp.Name, emp.Salary);
            }
            Console.ReadLine();

        }
    }
}
