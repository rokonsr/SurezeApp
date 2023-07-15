using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SurezeApp.Patients
{
    public interface IPatientDetailRepository
    {
        Task<long> CountAsync();
        Task<PatientDetail> CreatePatientAsync(PatientDetail patient);
        Task<List<AlternateIDType>> GetAlternateIDTypeAsync();
        Task<List<EducationLevel>> GetEducationLevelsAsync();
        Task<List<Language>> GetLanguagesAsync();
        Task<List<MaritalStatus>> GetMaritalStatusAsync();
        Task<List<Nationality>> GetNationalitiesAsync();
        Task<List<PatientRace>> GetPatientRacesAsync();
        Task<List<PatientTitle>> GetPatientTitleAsync();
        Task<List<Religion>> GetReligionsAsync();
        Task<PatientDetail> GetPatientDetailAsync(string id);
        Task UpdatePatientPageAsync(PatientDetail patient);
    }
}
