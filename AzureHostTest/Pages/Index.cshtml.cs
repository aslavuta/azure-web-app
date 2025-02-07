using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureHostTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IConfiguration Configuration;

        public IndexModel(ILogger<IndexModel> logger, IConfiguration configuration)
        {
            Configuration = configuration;
            _logger = logger;
        }

        public void OnGet()
        {

        }

        public string Message { get; set; }

        public void OnPostReadApplicationProperty()
        {
            var appSettingValue = Configuration["Environment"];
            Message = $"Application Settings value is: {appSettingValue}";
        }
    }
}
