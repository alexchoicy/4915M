using Microsoft.EntityFrameworkCore;
using WebApplication6.Data.Enity;

namespace WebApplication6.Helper
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

        public DbSet<Member> Member { get; set; }
    }
}
