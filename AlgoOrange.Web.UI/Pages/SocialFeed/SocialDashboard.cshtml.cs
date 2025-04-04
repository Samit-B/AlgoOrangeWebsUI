using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AlgoOrange.Web.UI.Pages
{
    public class SocialDashboarddModel : PageModel
    {
        private readonly ILogger<SocialDashboarddModel> _logger;


        public SocialDashboarddModel(ILogger<SocialDashboarddModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
