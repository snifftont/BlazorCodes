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

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public List<Department> departments { get; set; } = new List<Department>();

        public string departmentId { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            employee = await EmployeeService.GetEmployee(int.Parse(Id));
            departments=(await DepartmentService.GetDepartments()).ToList();
            departmentId=employee.DepartmentId.ToString();
        }
    }
}
