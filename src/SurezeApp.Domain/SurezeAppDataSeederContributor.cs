using SurezeApp.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace SurezeApp
{
    public class SurezeAppDataSeederContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<AlternateIDType, Guid> _alternateIdTypeRepository;
        private readonly IRepository<PatientTitle, Guid> _patientTitleRepository;
        private readonly IRepository<PatientRace, Guid> _patientRaceRepository;
        private readonly IRepository<Language, Guid> _languageRepository;
        private readonly IRepository<EducationLevel, Guid> _educationLevelRepository;
        private readonly IRepository<Nationality, Guid> _nationalityRepository;
        private readonly IRepository<Religion, Guid> _religionRepository;
        private readonly IRepository<MaritalStatus, Guid> _maritalStatusRepository;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public SurezeAppDataSeederContributor(IRepository<AlternateIDType, Guid> alternateIdTypeRepository, IRepository<PatientTitle, Guid> patientTitleRepository, IRepository<PatientRace, Guid> patientRaceRepository, IRepository<Language, Guid> languageRepository, IRepository<EducationLevel, Guid> educationLevelRepository, IRepository<Nationality, Guid> nationalityRepository, IRepository<Religion, Guid> religionRepository, IRepository<MaritalStatus, Guid> maritalStatusRepository)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            _alternateIdTypeRepository = alternateIdTypeRepository;
            _patientTitleRepository = patientTitleRepository;
            _patientRaceRepository = patientRaceRepository;
            _languageRepository = languageRepository;
            _educationLevelRepository = educationLevelRepository;
            _nationalityRepository = nationalityRepository;
            _religionRepository = religionRepository;
            _maritalStatusRepository = maritalStatusRepository;

        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _alternateIdTypeRepository.GetCountAsync() <= 0)
            {
                await _alternateIdTypeRepository.InsertAsync(
                    new AlternateIDType
                    {
                        Code = "MKA",
                        Name = "MyKad"
                    },
                    autoSave: true
                );
                await _alternateIdTypeRepository.InsertAsync(
                    new AlternateIDType
                    {
                        Code = "MKI",
                        Name = "MyKid"
                    },
                    autoSave: true
                );
                await _alternateIdTypeRepository.InsertAsync(
                    new AlternateIDType
                    {
                        Code = "OIC",
                        Name = "Old I/C"
                    },
                    autoSave: true
                );
            }

            if (await _patientTitleRepository.GetCountAsync() <= 0)
            {
                await _patientTitleRepository.InsertAsync(
                    new PatientTitle
                    {
                        Code = "NP001",
                        Name = "Baby of"
                    },
                    autoSave: true
                );
                await _patientTitleRepository.InsertAsync(
                    new PatientTitle
                    {
                        Code = "NP002",
                        Name = "Cik"
                    },
                    autoSave: true
                );
                await _patientTitleRepository.InsertAsync(
                    new PatientTitle
                    {
                        Code = "NP003",
                        Name = "Encik"
                    },
                    autoSave: true
                );
                await _patientTitleRepository.InsertAsync(
                    new PatientTitle
                    {
                        Code = "NP004",
                        Name = "Doktor"
                    },
                    autoSave: true
                );
            }

            if (await _patientRaceRepository.GetCountAsync() <= 0)
            {
                await _patientRaceRepository.InsertAsync(
                    new PatientRace
                    {
                        Code = "RAC0001",
                        Name = "MELAYU"
                    },
                    autoSave: true
                );
                await _patientRaceRepository.InsertAsync(
                    new PatientRace
                    {
                        Code = "RAC0002",
                        Name = "CINA"
                    },
                    autoSave: true
                );
                await _patientRaceRepository.InsertAsync(
                    new PatientRace
                    {
                        Code = "RAC0003",
                        Name = "INDIA"
                    },
                    autoSave: true
                );
                await _patientRaceRepository.InsertAsync(
                    new PatientRace
                    {
                        Code = "RAC0004",
                        Name = "PRIBUMI SABAH LAIN"
                    },
                    autoSave: true
                );
            }

            if (await _languageRepository.GetCountAsync() <= 0)
            {
                await _languageRepository.InsertAsync(
                    new Language
                    {
                        Code = "LG001",
                        Name = "English"
                    },
                    autoSave: true
                );
                await _languageRepository.InsertAsync(
                    new Language
                    {
                        Code = "LG002",
                        Name = "Malay"
                    },
                    autoSave: true
                );
                await _languageRepository.InsertAsync(
                    new Language
                    {
                        Code = "LG003",
                        Name = "Tamil"
                    },
                    autoSave: true
                );
                await _languageRepository.InsertAsync(
                    new Language
                    {
                        Code = "LG004",
                        Name = "Mandarin"
                    },
                    autoSave: true
                );
            }

            if (await _educationLevelRepository.GetCountAsync() <= 0)
            {
                await _educationLevelRepository.InsertAsync(
                    new EducationLevel
                    {
                        Code = "EDU001",
                        Name = "No Information"
                    },
                    autoSave: true
                );
                await _educationLevelRepository.InsertAsync(
                    new EducationLevel
                    {
                        Code = "EDU002",
                        Name = "PhD"
                    },
                    autoSave: true
                );
                await _educationLevelRepository.InsertAsync(
                    new EducationLevel
                    {
                        Code = "EDU003",
                        Name = "Sarjana"
                    },
                    autoSave: true
                );
                await _educationLevelRepository.InsertAsync(
                    new EducationLevel
                    {
                        Code = "EDU004",
                        Name = "Ijazah"
                    },
                    autoSave: true
                );
            }

            if (await _nationalityRepository.GetCountAsync() <= 0)
            {
                await _nationalityRepository.InsertAsync(
                    new Nationality
                    {
                        Code = "NAT001",
                        Name = "Afghan"
                    },
                    autoSave: true
                );
                await _nationalityRepository.InsertAsync(
                    new Nationality
                    {
                        Code = "NAT002",
                        Name = "Albanian"
                    },
                    autoSave: true
                );
                await _nationalityRepository.InsertAsync(
                    new Nationality
                    {
                        Code = "NAT003",
                        Name = "Algerian"
                    },
                    autoSave: true
                );
                await _nationalityRepository.InsertAsync(
                    new Nationality
                    {
                        Code = "NAT004",
                        Name = "American"
                    },
                    autoSave: true
                );
            }

            if (await _religionRepository.GetCountAsync() <= 0)
            {
                await _religionRepository.InsertAsync(
                    new Religion
                    {
                        Code = "REL000",
                        Name = "MAKLUMAT TIADA"
                    },
                    autoSave: true
                );
                await _religionRepository.InsertAsync(
                    new Religion
                    {
                        Code = "REL001",
                        Name = "ISLAM"
                    },
                    autoSave: true
                );
                await _religionRepository.InsertAsync(
                    new Religion
                    {
                        Code = "REL002",
                        Name = "KRISTIAN"
                    },
                    autoSave: true
                );
                await _religionRepository.InsertAsync(
                    new Religion
                    {
                        Code = "REL003",
                        Name = "BUDDHA"
                    },
                    autoSave: true
                );
            }

            if (await _maritalStatusRepository.GetCountAsync() <= 0)
            {
                await _maritalStatusRepository.InsertAsync(
                    new MaritalStatus
                    {
                        Code = "S",
                        Name = "Single"
                    },
                    autoSave: true
                );
                await _maritalStatusRepository.InsertAsync(
                    new MaritalStatus
                    {
                        Code = "M",
                        Name = "Married"
                    },
                    autoSave: true
                );
                await _maritalStatusRepository.InsertAsync(
                    new MaritalStatus
                    {
                        Code = "W",
                        Name = "Widowed"
                    },
                    autoSave: true
                );
                await _maritalStatusRepository.InsertAsync(
                    new MaritalStatus
                    {
                        Code = "D",
                        Name = "Divorced"
                    },
                    autoSave: true
                );
            }



        }
    }
}
