using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPageTienda.Models;

namespace RazorPageTienda.Data
{
    public class RazorPageTiendaContext : DbContext
    {
        public RazorPageTiendaContext (DbContextOptions<RazorPageTiendaContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPageTienda.Models.Product> Product { get; set; }
    }
}
