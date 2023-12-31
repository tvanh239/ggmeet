using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ggmeet.Models;

namespace ggmeet.Data
{
    public class ggmeetContext : DbContext
    {
        public ggmeetContext (DbContextOptions<ggmeetContext> options)
            : base(options)
        {
        }

        public DbSet<ggmeet.Models.User> User { get; set; } = default!;
    }
}
