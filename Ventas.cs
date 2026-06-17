using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TPV_Galo
{
    public class Ventas
    {
        public DateTime Date { get; set; }
        public List<CartItem> Items { get; set; }
        public decimal Total { get; set; }
        public MetodoPago MetodoPago { get; set; }

        public static class SalesRepository
        {
            public static BindingList<Ventas> Sales = new BindingList<Ventas>();
        }
    }
}
