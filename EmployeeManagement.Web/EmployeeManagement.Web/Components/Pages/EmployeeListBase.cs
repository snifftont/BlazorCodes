using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Components.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        public IEnumerable<Employee>? Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
           await Task.Run(LoadEmployees);
            //return base.OnInitializedAsync();
            
        }
        private void LoadEmployees()
        {
            Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "Test",
                LastName = "Test",
                Email = "Test@Test.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Test" },
                PhotoPath = "images/jon.png"
            };
           
            Employee e2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Test2",
                LastName = "Test",
                Email = "Test@Test.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Test" },
                PhotoPath = "images/jon.png"
            };
            Employee e3 =new Employee
            {
                EmployeeId = 3,
                FirstName = "Test3",
                LastName = "Test",
                Email = "Test@Test.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Test" },
                PhotoPath = "images/jon.png"
            };
            Employee e4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Test4",
                LastName = "Test",
                Email = "Test@Test.com",
                DateOfBirth = new DateTime(1980, 10, 5),
                Gender = Gender.Male,
                Department = new Department { DepartmentId = 1, DepartmentName = "Test" },
                PhotoPath = "images/jon.png"
            };
            Employees = new List<Employee> { e1, e2, e3, e4 };
        }
    }
}
