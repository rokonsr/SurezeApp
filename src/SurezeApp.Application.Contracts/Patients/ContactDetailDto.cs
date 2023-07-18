using System;
using Volo.Abp.Application.Dtos;

namespace SurezeApp.Patients
{
    public class ContactDetailDto : EntityDto<Guid>
    {
        public Guid PatientId { get; set; }
        public string ContactMode { get; set; } = string.Empty;
        public bool IsPrimary { get; set; }
        public string Address1 { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string Address3 { get; set; } = string.Empty;
        public string CountryCode { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber1 { get; set; } = string.Empty;
        public string PhoneNumber2 { get; set; } = string.Empty;
    }
}
