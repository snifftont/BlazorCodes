using AutoMapper;
using EmployeeManagement.Models;
using EmployeeManagement.Web.Components.Pages.Services;
using EmployeeManagement.Web.Models;
using Microsoft.AspNetCore.Components;

namespace EmployeeManagement.Web.Components.Pages
{
    public class EditEmployeeBase:ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        
        public string PageHeaderText { get; set; }
        public Employee employee { get; set; } = new Employee();
        public EditEmployeeModel editEmployeeModel { get; set; } =new EditEmployeeModel();

        [Inject]
        public IDepartmentService DepartmentService { get; set; }

        public List<Department> departments { get; set; } = new List<Department>();

        public string departmentId { get; set; }

        [Parameter]
        public string Id { get; set; }

        [Inject]
        public IMapper mapper { get; set; }
        
        [Inject]
        public NavigationManager navigationManager { get; set; }
        protected async override Task OnInitializedAsync()
        {
            int.TryParse(Id, out int employeeId);
            if(employeeId != 0)
            {
                PageHeaderText = "Edit Employee";
                employee = await EmployeeService.GetEmployee(int.Parse(Id));
            }
            else
            {
                PageHeaderText = "Create Employee";
                employee = new Employee
                {
                    DepartmentId = 1,
                    DateOfBirth = DateTime.Now,
                    PhotoPath = "images/nophoto.jpg"
                };
            }
            
            departments=(await DepartmentService.GetDepartments()).ToList();
            //departmentId=employee.DepartmentId.ToString();

            mapper.Map(employee, editEmployeeModel);
            
        }
        protected async Task HandleValidSubmit()
        {
            mapper.Map(editEmployeeModel, employee);
            Employee result = null;
            if(employee.EmployeeId!=0)
            {
                result = await EmployeeService.UpdateEmployee(employee);
            }
            else
            {
                result = await EmployeeService.CreateEmployee(employee);
            }
          
            if(result!=null)
            {
                navigationManager.NavigateTo("/");
            }
        }
        protected async Task Delete_Click()
        {
            await EmployeeService.DeleteEmployee(employee.EmployeeId);
            navigationManager.NavigateTo("/");
        }
    }
}
