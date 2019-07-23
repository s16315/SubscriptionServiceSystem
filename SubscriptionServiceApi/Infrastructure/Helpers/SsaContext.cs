using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SubscriptionServiceApi.Infrastructure.Models;

namespace SubscriptionServiceApi.Infrastructure
{
    public class SsaContext : DbContext
    {
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<HistoryLog> HistoryLogs { get; set; }
        public DbSet<Identifier> Identifiers { get; set; }
        public DbSet<InvoiceData> InvoiceData { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVersion> ProductVersions { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }


        public SsaContext(DbContextOptions<SsaContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(
                "server=31.179.186.242;" 
                + "port=59590;"
                + "database=SubscriptionServiceDB;" 
                + "user id=mtPanelDev;"
                + "password=a8YT*Qb!RcQi"
                );
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SsaContext>(options => options.UseMySQL(
                "DataSource=dbo.SubscriptionServiceDB.db",
                builder => builder.MigrationsAssembly("SubscriptionServiceApi.Infrastructure.Helpers")
                ));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subscription>().HasOne(x => x.User).WithMany(y => y.Subscriptions);
            modelBuilder.Entity<Subscription>().HasOne(x => x.Product).WithMany(y => y.Subscriptions);
        }

    }
}