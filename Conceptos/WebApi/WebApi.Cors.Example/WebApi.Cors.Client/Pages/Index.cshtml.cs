using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApi.Cors.Example;

namespace WebApi.Cors.Client.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<Buyer> Buyers { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public async Task OnGetAsync()
        {
            System.Threading.Thread.Sleep(30000);

            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync("https://localhost:44335/BuyersManagement");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                Buyers = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Buyer>>(content);
            }
        }
    }
}