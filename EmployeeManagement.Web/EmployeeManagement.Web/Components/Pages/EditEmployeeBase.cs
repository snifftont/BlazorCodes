using EmployeeManagement.Models;
using EmployeeManagement.Web.Components.Pages.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Components.Pages
{
    public class EditEmployeeBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        public Employee employee { get; set; } = new Employee();
        
        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            
            employee = await EmployeeService.GetEmployee(int.Parse(Id));
            

        }
    }
}
