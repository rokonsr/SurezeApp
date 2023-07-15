using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SurezeApp.Patients
{
    public interface IPatientDetailService : IApplicationService
    {
        Task<List<AlternateIDTypeDto>> GetAlternateIDTypeAsync();
        Task<List<PatientTitleDto>> GetPatientTitleAsync();
        Task<List<PatientRaceDto>> GetPatientRacesAsync();
        Task<List<LanguageDto>> GetLanguagesAsync();
        Task<List<EducationLevelDto>> GetEducationLevelsAsync();
        Task<List<NationalityDto>> GetNationalitiesAsync();
        Task<List<ReligionDto>> GetReligionsAsync();
        Task<List<MaritalStatusDto>> GetMaritalStatusAsync();
        Task<PatientDetailDto> CreatePatientAsync(PatientDetailDto Patient);
        Task<PatientDetailDto> GetPatientDetailAsync(string id);
        Task UpdatePatientPageAsync(PatientDetailDto Patient);
    }
}
