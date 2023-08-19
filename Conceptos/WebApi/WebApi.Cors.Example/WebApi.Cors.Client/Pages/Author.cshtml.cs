using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApi.Cors.Client.Pages
{
    public class AuthorModel : PageModel
    {
        private readonly ILogger<AuthorModel> _logger;
        public AuthorModel(ILogger<AuthorModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}