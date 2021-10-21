
using Microsoft.EntityFrameworkCore;
using pyronet.Core.Entities;

namespace pyronet.Repo.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}