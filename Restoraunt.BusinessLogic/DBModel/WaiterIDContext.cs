using Restoraunt.Domain.Entities.WaiterID;
using System.Data.Entity;

namespace Restoraunt.BusinessLogic.DBModel
{
    public class WaiterIDContext : DbContext
    {
        public WaiterIDContext() : base("name=Restoraunt") { }
        public DbSet<WaiterIDDbModel> WaiterIDs { get; set; }
    }
}