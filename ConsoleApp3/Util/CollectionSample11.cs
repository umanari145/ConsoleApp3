using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;


namespace ConsoleApp3.Util
{
    internal class CollectionSample11
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public int Age { get; set; }
        }

        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "佐藤", Department = "営業", Age = 34 },
            new Employee { Name = "鈴木", Department = "開発", Age = 28 },
            new Employee { Name = "高橋", Department = "営業", Age = 25 },
            new Employee { Name = "田中", Department = "開発", Age = 40 },
        };

        class Department
        {
            public string Code { get; set; }
            public string Name { get; set; }
        }

        List<Department> departments = new List<Department>
        {
            new Department { Code = "D1", Name = "開発" },
            new Department { Code = "D2", Name = "営業" },
        };

        class Staff
        {
            public string Name { get; set; }
            public string DeptCode { get; set; }
        }

        List<Staff> staffs = new List<Staff>
        {
            new Staff { Name = "山田", DeptCode = "D1" },
            new Staff { Name = "伊藤", DeptCode = "D2" },
            new Staff { Name = "渡辺", DeptCode = "D1" },
        };

        public void output()
        { 
            numbers.Where(n=>n % 2 ==0).Select(n=>n*n).ToList().ForEach(n=>Console.WriteLine(n));
            Console.WriteLine("-------------------------------------------------------------");
            employees.OrderBy(e => e.Department).ThenBy(e => e.Age).ToList().ForEach(n => Console.WriteLine(n.Name));
            Console.WriteLine("-------------------------------------------------------------");
            employees.GroupBy(e=>e.Department).Select(g=> new {departmenet = g.Key,Count = g.Count() })
                .ToList().ForEach(n => Console.WriteLine(n));
            Console.WriteLine(employees.Average(e => e.Age));
            Console.WriteLine(employees.MaxBy(e => e.Age).Name);
            staffs.Join(departments,
                s => s.DeptCode,
                d => d.Code,
                (s, d) => new
                {
                    Name = s.Name,
                    departmentName = d.Name
                }
                ).ToList().ForEach(n => Console.WriteLine(n.Name + "  " + n.departmentName));

        }        
    }
}
