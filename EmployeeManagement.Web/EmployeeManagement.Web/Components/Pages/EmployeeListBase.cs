using EmployeeManagement.Models;
using EmployeeManagement.Web.Components.Pages.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Components.Pages
{
    public class EmployeeListBase : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }   
        public IEnumerable<Employee> Employees { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Employees=(await EmployeeService.GetEmployees()).ToList();
           //await Task.Run(LoadEmployees);
            //return base.OnInitializedAsync();
            
        }
    }
}
