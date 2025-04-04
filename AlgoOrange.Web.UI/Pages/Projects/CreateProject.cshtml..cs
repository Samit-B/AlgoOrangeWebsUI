using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AlgoOrange.Web.UI.Pages
{
    public class CreateProjectModel : PageModel
    {
        private readonly ILogger<CreateProjectModel> _logger;


        public CreateProjectModel(ILogger<CreateProjectModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        } 
    }

}
