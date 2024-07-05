using EmployeeManagement.Models;

namespace EmployeeManagement.Web.Components.Pages.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetEmployees();
        
    }
}
