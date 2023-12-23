using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;

namespace ggmeet.Pages
{
    public class LoginModel : PageModel
    {
		public string Message { get; private set; } = "PageModel in C#";

		public void OnGet()
		{
			Message += $" Server time is {DateTime.Now}";
		}
	}
}
