
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using ggmeet.Helper;
using ggmeet.Data;
namespace ggmeet.Pages
{
    public class AccountInput
	{
        /// <summary>The Input Email</summary>
        public  string? Email { get; set; }
        /// <summary>The Input Password</summary>
        public  string? Password { get; set; }
	}
    public class LoginModel : PageModel
    {
        private readonly ggmeetContext _context;

        [BindProperty]
        public AccountInput AccountInput { get; set; } = default!;

        public LoginModel(ggmeetContext context)
        {
            _context = context;
        }
        public void OnGet()
        {

        }
        public  IActionResult OnPost()
        {
            if(AccountInput.Email == String.Empty || AccountInput.Password == String.Empty) {
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
                return Page();

            }
            

            return RedirectToPage("/Home/Index");

        }
    }
}
