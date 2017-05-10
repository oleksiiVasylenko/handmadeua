using System;
using System.Collections.Generic;
using Handmadeua.Core;
using Handmadeua.Data.Models.JoinedEntities;

namespace Handmadeua.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime AddedAt { get; set; }
        public string Location { get; set; }
        public ProductType Type { get; set; }

        public int CategoryId { get; set; }
        public int PhotoId { get; set; }
        public Category Category { get; set; }
        public List<Photo> Photos { get; set; }
        public List<MaterialProduct> MaterialProducts { get; set; }
        public List<ProductAuthor> ProductAuthors { get; set; }

        public Product()
        {
            Photos = new List<Photo>();
            MaterialProducts = new List<MaterialProduct>();
            ProductAuthors = new List<ProductAuthor>();
        }
    }
}
