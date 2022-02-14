using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageTienda.Data;
using RazorPageTienda.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace RazorPageTienda.Pages.Productos
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageTienda.Data.RazorPageTiendaContext _context;

        public IndexModel(RazorPageTienda.Data.RazorPageTiendaContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Name { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ProductName { get; set; }


        public async Task OnGetAsync()
        {
            IQueryable<string> nameQuery = from m in _context.Product
                                            orderby m.Name
                                            select m.Name;
            var products = from m in _context.Product
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                products = products.Where(s => s.Name.Contains(SearchString));
            }
            Name = new SelectList(await nameQuery.Distinct().ToListAsync());
            Product = await _context.Product.ToListAsync();
        }
    }
}
