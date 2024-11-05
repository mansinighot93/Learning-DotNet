using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SimpleWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<string> Technologies { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Technologies = new List<string>();
            Technologies.Add("Java");
            Technologies.Add("C#");
            Technologies.Add("C++");
            Technologies.Add("Javascript");

        }
    }
}
