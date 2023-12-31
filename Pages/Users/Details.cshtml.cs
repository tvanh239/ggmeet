using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ggmeet.Data;
using ggmeet.Models;

namespace ggmeet.Pages.Users
{
    public class DetailsModel : PageModel
    {
        private readonly ggmeet.Data.ggmeetContext _context;

        public DetailsModel(ggmeet.Data.ggmeetContext context)
        {
            _context = context;
        }

        public new User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }
    }
}
