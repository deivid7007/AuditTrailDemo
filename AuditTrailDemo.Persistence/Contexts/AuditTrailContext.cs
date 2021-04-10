namespace AuditTrailDemo.Persistence.Contexts
{
    using AuditTrailDemo.Persistence.DataEntities.ChangeLog;
    using AuditTrailDemo.Persistence.DataEntities.Product;
    using Microsoft.EntityFrameworkCore;

    public class AuditTrailContext : DbContext
    {
        public AuditTrailContext(DbContextOptions<AuditTrailContext> options) : base(options)
        {
        }

        internal DbSet<ProductDataEntity> Products { get; set; }

        internal DbSet<ChangeLogDataEntity> ChangeLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuditTrailContext).Assembly);
        }
    }
}
