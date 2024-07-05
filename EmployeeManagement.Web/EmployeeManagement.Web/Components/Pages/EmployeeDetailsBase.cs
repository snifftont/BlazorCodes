using EmployeeManagement.Models;
using EmployeeManagement.Web.Components.Pages.Services;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Components.Pages
{
    public class EmployeeDetailsBase:ComponentBase
    {
        public Employee employee { get; set; }= new Employee();
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id=Id?? "1";
            employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }
    }
}
