using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Microsoft.EntityFrameworkCore;

namespace SurezeApp.Patients
{
    public class PatientDetailRepository : DomainService, IPatientDetailRepository
    {
        private readonly IRepository<AlternateIDType, Guid> _alternateIdTypeRepository;
        private readonly IRepository<PatientTitle, Guid> _patientTitleRepository;
        private readonly IRepository<EducationLevel, Guid> _educationLevelRepository;
        private readonly IRepository<Language, Guid> _languageRepository;
        private readonly IRepository<MaritalStatus, Guid> _maritalStatusRepository;
        private readonly IRepository<Nationality, Guid> _nationalityRepository;
        private readonly IRepository<PatientRace, Guid> _patientRaceRepository;
        private readonly IRepository<Religion, Guid> _religionRaceRepository;
        private readonly IRepository<PatientDetail, Guid> _patientRepository;
        private readonly IRepository<ContactDetail, Guid> _contactRepository;

        public PatientDetailRepository(IRepository<AlternateIDType, Guid> alternateIdTypeRepository, IRepository<PatientTitle, Guid> patientTitleRepository, IRepository<EducationLevel, Guid> educationLevelRepository, IRepository<Language, Guid> languageRepository, IRepository<MaritalStatus, Guid> maritalStatusRepository, IRepository<Nationality, Guid> nationalityRepository, IRepository<PatientRace, Guid> patientRaceRepository, IRepository<Religion, Guid> religionRaceRepository, IRepository<PatientDetail, Guid> patientRepository, IRepository<ContactDetail, Guid> contactRepository) 
        {
            _alternateIdTypeRepository = alternateIdTypeRepository;
            _patientTitleRepository = patientTitleRepository;
            _educationLevelRepository = educationLevelRepository;
            _languageRepository = languageRepository;
            _maritalStatusRepository = maritalStatusRepository;
            _nationalityRepository = nationalityRepository;
            _patientRaceRepository = patientRaceRepository;
            _religionRaceRepository = religionRaceRepository;
            _patientRepository = patientRepository;
            _contactRepository = contactRepository;
        }

        public async Task<long> CountAsync()
        {
            return await _patientRepository.CountAsync();
        }

        public async Task<ContactDetail> CreateContactAsync(ContactDetail contactDetail)
        {
            var result = await _contactRepository.InsertAsync(contactDetail);
            return result;
        }

        public async Task<PatientDetail> CreatePatientAsync(PatientDetail patient)
        {
            var result = await _patientRepository.InsertAsync(patient);
            return result;
        }

        public async Task<List<AlternateIDType>> GetAlternateIDTypeAsync()
        {
            return await _alternateIdTypeRepository.GetListAsync();
        }

        public async Task<ContactDetail?> GetContactDetailAsync(Guid patientId)
        {
            return await _contactRepository.FirstOrDefaultAsync(x => x.PatientId == patientId);
        }

        public async Task<List<EducationLevel>> GetEducationLevelsAsync()
        {
            return await _educationLevelRepository.GetListAsync();
        }

        public async Task<List<Language>> GetLanguagesAsync()
        {
            return await _languageRepository.GetListAsync();
        }

        public async Task<List<MaritalStatus>> GetMaritalStatusAsync()
        {
            return await _maritalStatusRepository.GetListAsync();
        }

        public async Task<List<Nationality>> GetNationalitiesAsync()
        {
            return await _nationalityRepository.GetListAsync();
        }

        public async Task<PatientDetail> GetPatientDetailAsync(string id)
        {
            Guid guid = new(id);
            return await _patientRepository.FirstOrDefaultAsync(x => x.Id == guid);
        }

        public async Task<List<PatientRace>> GetPatientRacesAsync()
        {
            return await _patientRaceRepository.GetListAsync();
        }

        public async Task<List<PatientTitle>> GetPatientTitleAsync()
        {
            return await _patientTitleRepository.GetListAsync();
        }

        public async Task<List<Religion>> GetReligionsAsync()
        {
            return await _religionRaceRepository.GetListAsync();
        }

        public async Task UpdateContactAsync(ContactDetail contact)
        {
            var updateEntity = await _contactRepository.FirstOrDefaultAsync(x => x.PatientId == contact.PatientId);

            if (updateEntity == null)
            {
                await _contactRepository.InsertAsync(contact);
                return;
            }

            updateEntity.ContactMode = contact.ContactMode;
            updateEntity.IsPrimary = contact.IsPrimary;
            updateEntity.Address1 = contact.Address1;
            updateEntity.Address2 = contact.Address2;
            updateEntity.Address3 = contact.Address3;
            updateEntity.CountryCode = contact.CountryCode;
            updateEntity.PostalCode = contact.PostalCode;
            updateEntity.City = contact.City;
            updateEntity.State = contact.State;
            updateEntity.Email = contact.Email;
            updateEntity.PhoneNumber1 = contact.PhoneNumber1;
            updateEntity.PhoneNumber2 = contact.PhoneNumber2;

            await _contactRepository.UpdateAsync(updateEntity);
        }

        public async Task UpdatePatientPageAsync(PatientDetail patient)
        {
            var updateEntity = await _patientRepository.GetAsync(patient.Id);

            if (updateEntity == null)
            {
                return;
            }

            updateEntity.PrimaryProvider = patient.PrimaryProvider;
            updateEntity.MRN = patient.MRN;
            updateEntity.ActiveStatus = patient.ActiveStatus;
            updateEntity.PatientTitle = patient.PatientTitle;
            updateEntity.Suffix = patient.Suffix;
            updateEntity.FirstName = patient.FirstName;
            updateEntity.LastName = patient.LastName;
            updateEntity.NationalIDNumber = patient.NationalIDNumber;
            updateEntity.AlternateType = patient.AlternateType;
            updateEntity.AlternateIDNumber = patient.AlternateIDNumber;
            updateEntity.DateOfBirth = patient.DateOfBirth;
            updateEntity.Sex = patient.Sex;
            updateEntity.Race = patient.Race;
            updateEntity.Language = patient.Language;
            updateEntity.Ethnicity = patient.Ethnicity;
            updateEntity.EducationLevel = patient.EducationLevel;
            updateEntity.Nationality = patient.Nationality;
            updateEntity.Citizen = patient.Citizen;
            updateEntity.Religion = patient.Religion;
            updateEntity.MaritalStatus = patient.MaritalStatus;
            updateEntity.PatientCategory = patient.PatientCategory;
            updateEntity.ProfilePicture = patient.ProfilePicture;

            await _patientRepository.UpdateAsync(updateEntity);
        }
    }
}
