using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageTienda.Data;
using RazorPageTienda.Models;

namespace RazorPageTienda.Pages.Productos
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPageTienda.Data.RazorPageTiendaContext _context;

        public DetailsModel(RazorPageTienda.Data.RazorPageTiendaContext context)
        {
            _context = context;
        }

        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product.FirstOrDefaultAsync(m => m.ID == id);

            if (Product == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
