using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TPV_Galo
{
    public class ProductsRepository
    {
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>
        {
            // añador marca => new Product { Id = 1, Name = "Coca Cola", Price = 1.20m, Brand = Coca Cola, stock = 10}, 
            new Product { Id = 1, Name = "Coca Cola", Price = 1.20m, stock = 10},
            new Product { Id = 2, Name = "Agua", Price = 1.00m, stock = 10},
            new Product { Id = 3, Name = "Pan", Price = 0.80m, stock = 10},
            new Product { Id = 4, Name = "Patatas", Price = 1.90m, stock = 10},
            new Product { Id = 5, Name = "Chocolate", Price = 2.50m, stock = 10},
            new Product { Id = 6, Name = "Bebida energética", Price = 1.10m, stock = 10},
            new Product { Id = 7, Name = "Vapeador", Price = 8.50m, stock = 10},
            new Product { Id = 8, Name = "Fanta de naranja", Price = 1.20m, stock = 10},
            new Product { Id = 9, Name = "Naranja", Price = 0.20m, stock = 10},
            new Product { Id = 10, Name = "Pipas", Price = 1.00m, stock = 10},
            new Product { Id = 11, Name = "Croisant", Price = 1.50m, stock = 10},
            new Product { Id = 12, Name = "Sandwitch", Price = 3.80m, stock = 10}
        };
    }
}
