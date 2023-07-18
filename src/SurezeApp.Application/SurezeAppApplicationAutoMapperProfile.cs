using AutoMapper;
using SurezeApp.Patients;

namespace SurezeApp;

public class SurezeAppApplicationAutoMapperProfile : Profile
{
    public SurezeAppApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<PatientDetail, PatientDetailDto>();
        CreateMap<PatientDetailDto, PatientDetail>();

        CreateMap<AlternateIDType, AlternateIDTypeDto>();
        CreateMap<AlternateIDTypeDto, AlternateIDType>();

        CreateMap<PatientTitle, PatientTitleDto>();
        CreateMap<PatientTitleDto, PatientTitle>();

        CreateMap<PatientRace, PatientRaceDto>();
        CreateMap<PatientRaceDto, PatientRace>();

        CreateMap<EducationLevel, EducationLevelDto>();
        CreateMap<EducationLevelDto, EducationLevel>();

        CreateMap<Language, LanguageDto>();
        CreateMap<LanguageDto, Language>();

        CreateMap<Nationality, NationalityDto>();
        CreateMap<NationalityDto, Nationality>();

        CreateMap<Religion, ReligionDto>();
        CreateMap<ReligionDto, Religion>();

        CreateMap<MaritalStatus, MaritalStatusDto>();
        CreateMap<MaritalStatusDto, MaritalStatus>();

        CreateMap<PatientDetail, PatientDetailDto>();
        CreateMap<PatientDetailDto, PatientDetail>();

        CreateMap<PatientDetailListDto, PatientDetailDto>();
        CreateMap<PatientDetailDto, PatientDetailListDto>();

        CreateMap<ContactDetail, ContactDetailDto>();
        CreateMap<ContactDetailDto, ContactDetail>();
    }
}
