using ggmeet.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using ggmeet.Helper;
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
        private readonly ggmeet.Data.ggmeetContext _context;

        [BindProperty]
        public AccountInput AccountInput { get; set; } = default!;

        public LoginModel(ggmeet.Data.ggmeetContext context)
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
            var user = (from u in _context.User
                        select u
            ).Where(s => s.Email == AccountInput.Email).FirstOrDefault();
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid email or password.");
                return Page();
            }
            if (PasswordHelper.HashPassword(AccountInput.Password ?? "", user.SaltPassword ??"") != user.Password ){
                return Page();
            }
            //HttpContext.Session.SetString("User_ID", user);

            return RedirectToPage("/Home/Index");

        }
    }
}
