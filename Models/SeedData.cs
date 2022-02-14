using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPageTienda.Data;
using System;
using System.Linq;

namespace RazorPageTienda.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPageTiendaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPageTiendaContext>>()))
            {
                // Look for any movies.
                if (context.Product.Any())
                {
                    return;   // DB has been seeded
                }

                context.Product.AddRange(
                


                    new Product
                    {
                        Name = "Fanta",
                        FecCaduc = DateTime.Parse("2022-2-13"),
                        Stock = 23,
                        Price = 2.05M,
                        Rating = "R"
                    },
                      new Product
                      {
                          Name = "Aquarius",
                          FecCaduc = DateTime.Parse("2022-2-10"),
                          Stock = 15,
                          Price = 1.85M,
                          
                          Rating = "R"
                      },
                        new Product
                        {
                            Name = "Amstel",
                            FecCaduc = DateTime.Parse("2022-2-09"),
                            Stock = 14,
                            Price = 1.50M,
                            Rating = "R"
                        }
                );
                context.SaveChanges();
            }
        }
    }
}
