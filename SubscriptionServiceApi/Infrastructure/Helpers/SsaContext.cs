using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SubscriptionServiceApi.Infrastructure.Models;

namespace SubscriptionServiceApi.Infrastructure
{
    public class SsaContext : DbContext
    {
        internal DbSet<User> Users { get; set; }
        internal DbSet<Address> Addresses { get; set; }
        internal DbSet<Discount> Discounts { get; set; }
        internal DbSet<InvoiceData> InvoiceData { get; set; }
        internal DbSet<Person> Persons { get; set; }
        internal DbSet<Product> Products { get; set; }
        internal DbSet<ProductVersion> ProductVersions { get; set; }
        internal DbSet<Subscription> Subscriptions { get; set; }
        
        public SsaContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=31.179.186.242;port=59590;database=SubscriptionService;user id=mtPanelDev;password=a8YT*Qb!RcQi");
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SsaContext>();
            
            services.AddDbContext<SsaContext>(options => options.UseMySQL("DataSource=dbo.SubscriptionServiceApi.db",
                builder => builder.MigrationsAssembly("SSA")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subscription>().HasOne(x => x.User).WithMany(y => y.Subscriptions);
            modelBuilder.Entity<Subscription>().HasOne(x => x.Product).WithMany(y => y.Subscriptions);
        }

    }
}