using System;
namespace CartApi.Models
{
    public class Cart
    {
        public int CartId { get; set; }

        public string ProductId { get; set; }

        public double ProductPrice { get; set; }

        public string Total { get; set; }

        public string OrderStatus { get; set; }

        public string OrderId { get; set; }
    }
}
