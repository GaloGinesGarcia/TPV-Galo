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
            new Product { Id = 1, Name = "Coca Cola", Price = 1.50m },
            new Product { Id = 2, Name = "Agua", Price = 1.00m },
            new Product { Id = 3, Name = "Pan", Price = 0.80m }
        };
    }
}
