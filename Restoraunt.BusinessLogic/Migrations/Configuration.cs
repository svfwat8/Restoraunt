namespace Restoraunt.BusinessLogic.Migrations
{
    using Restoraunt.Domain.Entities.Product;
    using Restoraunt.Domain.Entities.User;
    using Restoraunt.Domain.Enums.User;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web.Helpers;

    internal sealed class Configuration : DbMigrationsConfiguration<Restoraunt.BusinessLogic.DBModel.UserContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Restoraunt.BusinessLogic.DBModel.UserContext";
        }

        protected override void Seed(Restoraunt.BusinessLogic.DBModel.UserContext ctx)
        {
        }
    }
}
