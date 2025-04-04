using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AlgoOrange.Web.UI.Pages
{
    public class EcommerceDashboardModel : PageModel
    {
        private readonly ILogger<EcommerceDashboardModel> _logger;


        public EcommerceDashboardModel(ILogger<EcommerceDashboardModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}

