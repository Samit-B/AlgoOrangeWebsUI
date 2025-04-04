using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AlgoOrange.Web.UI.Pages
{
    public class StockDashboarddModel : PageModel
    {
        private readonly ILogger<StockDashboarddModel> _logger;


        public StockDashboarddModel(ILogger<StockDashboarddModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
