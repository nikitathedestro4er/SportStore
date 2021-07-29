using System.Collections;
using System.Collections.Generic;

namespace SportStore.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }

        void SaveProduct(Product product);
        Product DeleteProduct(int productId);
        
    }
}