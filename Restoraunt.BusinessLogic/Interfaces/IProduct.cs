using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restoraunt.Domain.Entities.Product;

namespace Restoraunt.BusinessLogic.Interfaces
{
    public interface IProduct
    {
        ProductDTO GetProductById(int id);
        IEnumerable<ProductDTO> GetAll();
        void CreateProduct(ProductDTO product);
        bool DeleteProduct(int productId);
        void UpdateProduct(ProductDTO product);
    }
}
