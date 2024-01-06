using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ggmeet.Pages.Home
{
    public class IndexModel : PageModel
    {
        public string? TimeNow { get; set; }
        public void OnGet()
        {
            TimeNow += $"{DateTime.Now}";
        }
    }
}
