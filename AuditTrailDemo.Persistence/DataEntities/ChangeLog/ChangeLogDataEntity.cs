namespace AuditTrailDemo.Persistence.DataEntities.ChangeLog
{
    using AuditTrailDemo.Persistence.Enums.ChangeLog;
    using System;

    public class ChangeLogDataEntity
    {
        public Guid Id { get; set; }

        public string EntityId { get; set; }

        public string EntityName { get; set; }

        public string PropertyName { get; set; }

        public string OldValue { get; set; }

        public string NewValue { get; set; }

        public DateTime ChangedOn { get; set; }

        public ChangeLogActionType Type { get; set; }

        public string ChangedBy { get; set; }

        public string ExecutablePath { get; set; }
    }
}
