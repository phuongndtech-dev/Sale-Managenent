﻿namespace Sale.Domain.Entity
{
    public class Shop
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public virtual Product Product { get; set; }
    }
}