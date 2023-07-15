using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace SurezeApp.Patients
{
    public class SpecimenOrder : AuditedAggregateRoot<Guid>
    {
        public string LocationType { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public string Priority { get; set; } = string.Empty;

        public Guid PatientId { get; set; }
    }
}
