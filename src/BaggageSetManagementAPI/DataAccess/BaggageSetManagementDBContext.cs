using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Pitstop.Application.BaggageSetManagement.Model;
using Polly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pitstop.Application.BaggageSetManagement.DataAccess
{
    public class BaggageSetManagementDBContext : DbContext
    {
        public BaggageSetManagementDBContext(DbContextOptions<BaggageSetManagementDBContext> options) : base(options)
        {
        }

        public DbSet<BaggageSet> BaggageSets { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BaggageSet>().HasKey(b => b.ScheduledFlightId);
            builder.Entity<BaggageSet>().ToTable("BaggageSet");
            base.OnModelCreating(builder);
        }

        public void MigrateDB()
        {
            Policy
                .Handle<Exception>()
                .WaitAndRetry(10, r => TimeSpan.FromSeconds(10))
                .Execute(() => Database.Migrate());
        }
    }
}
