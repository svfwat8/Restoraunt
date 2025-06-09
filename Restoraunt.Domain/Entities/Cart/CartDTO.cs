using Restoraunt.Domain.Entities.Product;
using System.Collections.Generic;

namespace Restoraunt.Domain.Entities.Cart
{
    public class CartDTO
    {
        public int Id { get; set; }
        public List<ProductDTO> ProductsInCart { get; set; }
        public decimal Price { get; set; } = 0;
        public decimal Discount { get; set; } = 0;
    }
}
