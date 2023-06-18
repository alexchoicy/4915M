using Microsoft.EntityFrameworkCore;
using Server.Model.Entity;
using System.Diagnostics.Contracts;
using Contract = Server.Model.Entity.Contract;

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
        public DbSet<Account> account { get; set; }
        public DbSet<Staff> staff { get; set; }
        public DbSet<Dept> dept { get; set; }
        public DbSet<Position> position { get; set; }
        public DbSet<item> item { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<Restaurant> restaurant { get; set; }
        public DbSet<Item_Order> item_order { get; set; }
        public DbSet<Suppliers> suppliers { get; set; }
        public DbSet<Mapping> mapping { get; set; }
        public DbSet<RestaurantType> RestaurantType { get; set; }
        public DbSet<AccessControl> AccessControl { get; set; }
        public DbSet<Category> category { get; set; } 
        public DbSet<Restaurant_item> restaurant_item { get; set; }
        public DbSet<Contract> contract { get; set; }
        public DbSet<PlanContract> planContracts { get; set; }
        public DbSet<PlanContract_Item> planContract_Items { get; set; }
        public DbSet<Buy> buy { get; set; }
        public DbSet<item_buy> item_buy { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .ToTable("account");

            modelBuilder.Entity<Staff>()
                .ToTable("staff");

            modelBuilder.Entity<Dept>()
                .ToTable("dept");

            modelBuilder.Entity<Position>()
                .ToTable("position");

            modelBuilder.Entity<item>()
                .ToTable("item");

            modelBuilder.Entity<Order>()
                .ToTable("order");

            modelBuilder.Entity<Restaurant>()
                .ToTable("restaurant");

            modelBuilder.Entity<Item_Order>()
                .ToTable("item_order");

            modelBuilder.Entity<Suppliers>()
                .ToTable("suppliers");

            modelBuilder.Entity<Mapping>()
                .ToTable("mapping");

            modelBuilder.Entity<RestaurantType>()
                .ToTable("RestaurantType");

            modelBuilder.Entity<AccessControl>()
                .ToTable("AccessControl").HasKey("categoryID","typeID");

            modelBuilder.Entity<Category>()
                .ToTable("category");
            modelBuilder.Entity<Restaurant_item>()
                .ToTable("restaurant_item").HasKey("restaurantID", "itemID");

            modelBuilder.Entity<Contract>()
                .ToTable("contract");

            modelBuilder.Entity<PlanContract>()
                .ToTable("PlanContract");
            modelBuilder.Entity<PlanContract_Item>()
                .ToTable("PlanContract_Item").HasKey("planContractID", "ItemID");
            modelBuilder.Entity<Buy>()
                .ToTable("Buy");
            modelBuilder.Entity<item_buy>()
                .ToTable("item_table").HasKey("BuyID", "itemID");
        }
    }
}
