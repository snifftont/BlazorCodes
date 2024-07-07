using EmployeeManagement.Models;
using EmployeeManagement.Web.Components.Pages.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Connections.Features;

namespace EmployeeManagement.Web.Components.Pages
{
    public class EmployeeDetailsBase:ComponentBase
    {
        public Employee employee { get; set; }= new Employee();
        protected string coordinates { get; set; }
        public string ButtonText { get; set; } = "Hide Footer";
        public string cssClass { get; set; } = null;

        [Inject]
        public IEmployeeService EmployeeService { get; set; }
        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id=Id?? "1";
            employee = await EmployeeService.GetEmployee(int.Parse(Id));
        }

        protected void Mouse_Move(MouseEventArgs e)
        {
            coordinates = $"X ={e.ClientX} Y={e.ClientY}";
        }

        protected void Button_Click()
        {
            if(ButtonText=="Hide Footer")
            {
                ButtonText = "Show Footer";
                cssClass = "displayNone";
            }
            else
            {
                cssClass = null;
                ButtonText = "Hide Footer";
            }
        }

    }
}
