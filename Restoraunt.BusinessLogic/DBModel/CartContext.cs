using Restoraunt.Domain.Entities.Cart;
using Restoraunt.Domain.Entities.WaiterID;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.BusinessLogic.DBModel
{
    public class CartContext : DbContext
    {
        public CartContext() : base("name=Restoraunt") { }
        public DbSet<CartDbModel> Carts { get; set; }
    }
}
