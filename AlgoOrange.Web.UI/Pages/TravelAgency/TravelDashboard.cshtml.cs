using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AlgoOrange.Web.UI.Pages
{
    public class TravelDashboarddModel : PageModel
    {
        private readonly ILogger<TravelDashboarddModel> _logger;


        public TravelDashboarddModel(ILogger<TravelDashboarddModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
