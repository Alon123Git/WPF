using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using TEST.Models;

namespace TEST.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        // constructors
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option) { }
        public ApplicationDbContext() { }
        // constructors

        // Tables
        public DbSet<LocalUser> LocalUser { get; set; }
        public DbSet<Login> Login { get; set; }
        public DbSet<Register> Register { get; set; }
        // Tables

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("ManageProgramConnectionString");
            }
        }
    }

    public class CalculatorDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ManageProgramConnectionString"));

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}