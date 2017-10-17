using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using BookStore.Domain.Account.Entities;
using BookStore.Infra.Data.Mappings;

namespace BookStore.Infra.Data.Context
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext()
            : base("BookStoreContext")
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();

            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}