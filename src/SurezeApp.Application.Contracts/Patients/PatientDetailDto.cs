using System;
using Volo.Abp.Application.Dtos;

namespace SurezeApp.Patients
{
    public class PatientDetailDto : EntityDto<Guid>
    {
        public string PrimaryProvider { get; set; } = string.Empty;
        public string MRN { get; set; } = string.Empty;
        public string ActiveStatus { get; set; } = string.Empty;
        public string PatientTitle { get; set; } = string.Empty;
        public string Suffix { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string NationalIDNumber { get; set; } = string.Empty;
        public string AlternateType { get; set; } = string.Empty;
        public string AlternateIDNumber { get; set; } = string.Empty;
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; } = string.Empty;
        public string Race { get; set; } = string.Empty;
        public string Language { get; set; } = string.Empty;
        public string Ethnicity { get; set; } = string.Empty;
        public string EducationLevel { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string Citizen { get; set; } = string.Empty;
        public string Religion { get; set; } = string.Empty;
        public string MaritalStatus { get; set; } = string.Empty;
        public string PatientCategory { get; set; } = string.Empty;
        public string ProfilePicture { get; set; } = string.Empty;
    }
}
