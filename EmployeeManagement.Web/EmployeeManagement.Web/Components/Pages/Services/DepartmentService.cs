using EmployeeManagement.Models;

namespace EmployeeManagement.Web.Components.Pages.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly HttpClient httpClient;

        public DepartmentService(HttpClient httpClient) 
        {
            this.httpClient = httpClient;
        }

        public async Task<Department> GetDepartment(int id)
        {
            return  await httpClient.GetFromJsonAsync<Department>($"https://localhost:7271/api/departments/{id}");
        }

        public async Task<IEnumerable<Department>> GetDepartments()
        {
            return await httpClient.GetFromJsonAsync<Department[]>("https://localhost:7271/api/departments");
        }
    }
}
