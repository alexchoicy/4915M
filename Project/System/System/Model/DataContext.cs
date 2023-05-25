using Microsoft.EntityFrameworkCore;
using Server.Model.Entity;

namespace Server.Model
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // in memory database used for simplicity, change to a real db for production applications
            var conntectionString = _configuration.GetConnectionString("conDB");
            options.UseMySql(conntectionString,ServerVersion.AutoDetect(conntectionString));

        }
        public DbSet<Staff> staff { get; set; }
        public DbSet<Account> account { get; set; }
        public DbSet<Dept> dept { get; set; }
        public DbSet<Position> position { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().ToTable("staff");
        }
    }
}
