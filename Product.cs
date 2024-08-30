﻿using Microsoft.AspNetCore.Mvc;

namespace WebAppOnlineMart.Models
{
    public class Product : Controller
    {
        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;


        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
