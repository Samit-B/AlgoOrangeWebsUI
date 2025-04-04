using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AlgoOrange.Web.UI.Pages
{
    public class ProjectDashboardModel : PageModel
    {
        private readonly ILogger<ProjectDashboardModel> _logger;


        public ProjectDashboardModel(ILogger<ProjectDashboardModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        } 
    }

}
