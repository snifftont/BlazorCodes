using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace EmployeeManagement.Web.Data
{
    public class EmployeeManagementWebContext(DbContextOptions<EmployeeManagementWebContext> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
