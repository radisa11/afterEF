using Microsoft.EntityFrameworkCore;

namespace afterEF.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions<MyContext> options) : base(options) { }
        
        public DbSet<Animal> Animals {get;set;}
    }
}