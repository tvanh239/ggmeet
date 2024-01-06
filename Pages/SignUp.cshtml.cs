using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ggmeet.Helper;
using ggmeet.Data;
namespace ggmeet.Pages
{
    public class SignUpModel : PageModel
    {
		private readonly ggmeetContext _context;

		public SignUpModel(ggmeetContext context)
		{
			_context = context;
		}
		public IActionResult OnGet()
		{
			return Page();
		}
		[BindProperty]
		public new User User { get; set; } = default!;


		public async Task<IActionResult> OnPostAsync()
		{
			
			User.CreateDate = DateTime.Now;
			User.IsDelete = false;
			User.SaltPassword = PasswordHelper.GenerateSalt();
			User.Password = PasswordHelper.HashPassword(User.Password,User.SaltPassword);
			if (!ModelState.IsValid)
			{
				return Page();
			}

			
			await _context.SaveChangesAsync();

			return RedirectToPage("./Index");
		}
	}
}
