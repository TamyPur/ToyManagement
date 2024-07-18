using Microsoft.Ajax.Utilities;
using Server.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Reflection;

namespace Server.DAL
{
    public class StoreContext : DbContext
    {

        public StoreContext() : base("name= ToysManagementConnectionString")
        {
        }

        public DbSet<Toy> Toys { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}