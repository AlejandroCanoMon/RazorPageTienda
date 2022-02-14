using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RazorPageTienda.Models
{
    public class Product { 
      public int ID { get; set; }
    public string Name { get; set; }

    [DataType(DataType.Date)]
    public DateTime FecCaduc { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }
    }
}
