namespace AuditTrailDemo.Persistence.Contexts.Configurations.ChangeLog
{
    using AuditTrailDemo.Persistence.DataEntities.ChangeLog;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class ChangeLogDataEntityConfiguration : IEntityTypeConfiguration<ChangeLogDataEntity>
    {
        public void Configure(EntityTypeBuilder<ChangeLogDataEntity> builder)
        {
            builder
               .HasKey(changeLogDataEntity => changeLogDataEntity.Id);

            builder
               .Property(changeLogDataEntity => changeLogDataEntity.ChangedBy)
               .IsRequired();

            builder
               .Property(changeLogDataEntity => changeLogDataEntity.ChangedOn)
               .IsRequired();

            builder
               .Property(changeLogDataEntity => changeLogDataEntity.EntityId)
               .IsRequired();

            builder
               .Property(changeLogDataEntity => changeLogDataEntity.EntityName)
               .IsRequired();

            builder
               .Property(changeLogDataEntity => changeLogDataEntity.ExecutablePath)
               .IsRequired();

            builder
               .Property(changeLogDataEntity => changeLogDataEntity.PropertyName)
               .IsRequired();

            builder
               .Property(changeLogDataEntity => changeLogDataEntity.Type)
               .IsRequired();
        }
    }
}
