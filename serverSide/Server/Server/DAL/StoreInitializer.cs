using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Server.Models;
using System.Diagnostics;

namespace Server.DAL
{
    public class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {

            var users = new List<User>
            {
            new User{UserName="maneger", Password="passManeger"},

            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var toys = new List<Toy>
            {
            new Toy{CatalogNumber=1,Title="משחק מטורף",Description="wow, its very butiful",Price=20, OrdersAmount=6},
            };

            toys.ForEach(s => context.Toys.Add(s));
            context.SaveChanges();
        }
    }
}