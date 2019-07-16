using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace demoMVC.Models
{
    public class demoMVCContext : DbContext
    {
        public demoMVCContext (DbContextOptions<demoMVCContext> options)
            : base(options)
        {
        }

        public DbSet<demoMVC.Models.Filme> Filme { get; set; }
    }
}
