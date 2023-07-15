using System.Collections.Generic;
using System.Threading.Tasks;

namespace SurezeApp.Patients
{
    public class PatientDetailService : SurezeAppAppService, IPatientDetailService
    {
        private readonly IPatientDetailRepository _patientDetailRepository;

        public PatientDetailService(IPatientDetailRepository patientDetailRepository)
        {
            _patientDetailRepository = patientDetailRepository;
        }

        public async Task<PatientDetailDto> CreatePatientAsync(PatientDetailDto Patient)
        {
            var patient = ObjectMapper.Map<PatientDetailDto, PatientDetail>(Patient);
            var entity = await _patientDetailRepository.CreatePatientAsync(patient);
            return ObjectMapper.Map<PatientDetail, PatientDetailDto>(entity);
        }

        public async Task<List<AlternateIDTypeDto>> GetAlternateIDTypeAsync()
        {
            var alternateIdType = await _patientDetailRepository.GetAlternateIDTypeAsync();
            return ObjectMapper.Map<List<AlternateIDType>, List<AlternateIDTypeDto>>(alternateIdType);
        }

        public async Task<List<EducationLevelDto>> GetEducationLevelsAsync()
        {
            var educationLevel = await _patientDetailRepository.GetEducationLevelsAsync();
            return ObjectMapper.Map<List<EducationLevel>, List<EducationLevelDto>>(educationLevel);
        }

        public async Task<List<LanguageDto>> GetLanguagesAsync()
        {
            var languages = await _patientDetailRepository.GetLanguagesAsync();
            return ObjectMapper.Map<List<Language>, List<LanguageDto>>(languages);
        }

        public async Task<List<MaritalStatusDto>> GetMaritalStatusAsync()
        {
            var maritalStatus = await _patientDetailRepository.GetMaritalStatusAsync();
            return ObjectMapper.Map<List<MaritalStatus>, List<MaritalStatusDto>>(maritalStatus);
        }

        public async Task<List<NationalityDto>> GetNationalitiesAsync()
        {
            var nationality = await _patientDetailRepository.GetNationalitiesAsync();
            return ObjectMapper.Map<List<Nationality>, List<NationalityDto>>(nationality);
        }

        public async Task<List<PatientRaceDto>> GetPatientRacesAsync()
        {
            var races = await _patientDetailRepository.GetPatientRacesAsync();
            return ObjectMapper.Map<List<PatientRace>, List<PatientRaceDto>>(races);
        }

        public async Task<PatientDetailDto> GetPatientDetailAsync(string id)
        {
            var patient = await _patientDetailRepository.GetPatientDetailAsync(id);
            return ObjectMapper.Map<PatientDetail, PatientDetailDto>(patient);
        }

        public async Task<List<PatientTitleDto>> GetPatientTitleAsync()
        {
            var patientTitle = await _patientDetailRepository.GetPatientTitleAsync();
            return ObjectMapper.Map<List<PatientTitle>, List<PatientTitleDto>>(patientTitle);
        }

        public async Task<List<ReligionDto>> GetReligionsAsync()
        {
            var religions = await _patientDetailRepository.GetReligionsAsync();
            return ObjectMapper.Map<List<Religion>, List<ReligionDto>>(religions);
        }

        public async Task UpdatePatientPageAsync(PatientDetailDto Patient)
        {
            var patient = ObjectMapper.Map<PatientDetailDto, PatientDetail>(Patient);
            await _patientDetailRepository.UpdatePatientPageAsync(patient);
        }
    }
}
