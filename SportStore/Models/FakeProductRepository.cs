using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace SportStore.Models
{
    public class FakeProductRepository /*: IProductRepository*/
    {
        public IEnumerable<Product> Products => new List<Product>
        {
            new Product {Name = "Football", Price = 25},
            new Product {Name = "Surfboard", Price = 179},
            new Product {Name = "Running shoes", Price = 95}
        };
        
        
        
    }
}