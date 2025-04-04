using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AlgoOrange.Web.UI.Pages
{
    public class CRMDashboarddModel : PageModel
    {
        private readonly ILogger<CRMDashboarddModel> _logger;


        public CRMDashboarddModel(ILogger<CRMDashboarddModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        } 
    }

}
