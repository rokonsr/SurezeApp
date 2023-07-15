using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SurezeApp.Patients
{
    public class ContactMode : AuditedAggregateRoot<Guid>
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
    }
}
