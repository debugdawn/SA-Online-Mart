using Microsoft.AspNetCore.Mvc;

namespace WebAppOnlineMart.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
