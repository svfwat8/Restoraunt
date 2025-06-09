using Restoraunt.Domain.Entities.Order;
using Restoraunt.Domain.Entities.Product;
using Restoraunt.Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.BusinessLogic.DBModel
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=Restoraunt") { }
        public DbSet<UserDbModel> Users { get; set; }
    }
}
