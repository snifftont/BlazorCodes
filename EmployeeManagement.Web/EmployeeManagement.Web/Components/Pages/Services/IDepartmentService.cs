using EmployeeManagement.Models;

namespace EmployeeManagement.Web.Components.Pages.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartments();
        Task<Department> GetDepartment(int id);
    }
}
