using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Data
{
    public class OmuNaviContext : DbContext
    {
        public OmuNaviContext(DbContextOptions<OmuNaviContext> options)
            : base(options)
        {
        }

        public DbSet<Restaurant> Restaurants { get; set; }
    }

    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Cuisine { get; set; }
    }
}