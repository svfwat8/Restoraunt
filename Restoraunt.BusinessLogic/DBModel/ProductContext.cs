using Restoraunt.Domain.Entities.WaiterID;
using Restoraunt.Domain.Entities.Product;
using System.Data.Entity;

namespace Restoraunt.BusinessLogic.DBModel
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("name=Restoraunt") { }
        public DbSet<ProductDbModel> Products { get; set; }
    }
}
