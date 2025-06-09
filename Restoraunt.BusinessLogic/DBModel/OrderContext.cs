using Restoraunt.Domain.Entities.WaiterID;
using Restoraunt.Domain.Entities.Order;
using System.Data.Entity;

namespace Restoraunt.BusinessLogic.DBModel
{
    public class OrderContext : DbContext
    {
        public OrderContext() : base("name=Restoraunt") { }
        public DbSet<OrderDbModel> Orders { get; set; }
    }
}