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
    public class IndexModel : PageModel
    {
        private readonly ggmeet.Data.ggmeetContext _context;

        public IndexModel(ggmeet.Data.ggmeetContext context)
        {
            _context = context;
        }

        public new IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
