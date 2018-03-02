using System;
using System.Collections.Generic;
using System.Text;

namespace AppShop
{
    public class Phone
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }
        public string ImageFile { get; set; }
    }

    public class OrderItem
    {
        public Phone Phone { get; set; }
        public int Count { get; set; }
    }

    public class Order
    {
        public List<OrderItem> Orders { get; set; } = new List<OrderItem>();
    }


}
