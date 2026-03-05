using Civiq.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civiq.Persistence.Contexts
{
    public class CiviqContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public CiviqContext(DbContextOptions<CiviqContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Camera> Cameras { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Evidence> Evidence { get; set; }
        public DbSet<Fine> Fines { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Violation> Violations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("Default"));
            base.OnConfiguring(optionsBuilder);
        }

    }
}
