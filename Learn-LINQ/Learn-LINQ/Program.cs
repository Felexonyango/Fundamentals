using System;
using System.Collections.Generic;
using System.Linq;

class Learn
{
    static void Main(string[] args)
    {
        // Collection of employees
        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Alice", DepartmentId = 101 },
            new Employee { Id = 2, Name = "Bob", DepartmentId = 102 },
            new Employee { Id = 3, Name = "Charlie", DepartmentId = 101 },
        };

        // Collection of departments
        var departments = new List<Department>
        {
            new Department { Id = 101, Name = "HR" },
            new Department { Id = 102, Name = "Finance" },
        };

        //GroupBy

        var groupedByData = employees.GroupBy(emp => emp.DepartmentId);

        foreach (var item in groupedByData)
        {

            foreach (var emp in item)
            {
                
                Console.WriteLine(emp.Name);
            }
        }


        // Using LINQ Join to combine employees and departments
        //var employeeDetails = employees.Join   (
        //    departments,                      
        //    emp => emp.DepartmentId,          
        //    dept => dept.Id,                 
        //    (emp, dept) => new                
        //    {
        //        EmployeeName = emp.Name,
        //        DepartmentName = dept.Name
        //    });

        // Display the results
        //foreach (var detail in employeeDetails)
        //{
        //    Console.WriteLine($"Employee: {detail.EmployeeName}, Department: {detail.DepartmentName}");
        //}

        //GroupJoin 
        var groupedData = departments.GroupJoin(
          employees,                     
          dept => dept.Id,              
          emp => emp.DepartmentId,       
          (dept, empGroup) => new        
          {
              DepartmentName = dept.Name,
              Employees = empGroup
          });

        // Display the grouped results
        foreach (var group in groupedData)
        {
            Console.WriteLine($"Department: {group.DepartmentName}");
            foreach (var emp in group.Employees)
            {
                Console.WriteLine($"  Employee: {emp.Name}");
            }
        }
    }
}

// Employee class
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int DepartmentId { get; set; }
}

// Department class
class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
}
