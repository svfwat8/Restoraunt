using Restoraunt.Domain.Entities.Contact;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt.BusinessLogic.DBModel
{
    public class ContactContext : DbContext
    {
        public ContactContext() : base("name=Restoraunt") { }
        public DbSet<ContactDbModel> Contacts { get; set; }
    }
}
