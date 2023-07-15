using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.ObjectMapping;

namespace SurezeApp.Patients
{
    public class PatientService : SurezeAppAppService, IPatientService
    {
        private IPatientRepository _patientRepository;
        private IPatientDetailRepository _patientDetailRepository;
        public PatientService(IPatientRepository patientRepository, IPatientDetailRepository patientDetailRepository)
        {
            _patientRepository = patientRepository;
            _patientDetailRepository = patientDetailRepository;
        }

        public async Task<PagedResultDto<PatientDetailDto>> GetPatientListAsync(GetPatientListDto input)
        {
            if (input.Sorting.IsNullOrWhiteSpace())
            {
                input.Sorting = nameof(PatientDetail.FirstName);
            }

            var authors = await _patientRepository.GetPatientListAsync(
                input.SkipCount,
                input.MaxResultCount,
                input.Sorting,
                input.Filter
            );

            var totalCount = input.Filter == null
                ? await _patientRepository.CountAsync()
                : await _patientRepository.CountAsync(
                    author => author.FirstName.Contains(input.Filter));

           var maritalStatus = await _patientDetailRepository.GetMaritalStatusAsync();

            var patients = (from a in authors
                           join m in maritalStatus on a.MaritalStatus equals m.Code
                           select new PatientDetailListDto { Id = a.Id, FirstName = a.FirstName, LastName = a.LastName, MaritalStatus = m.Name }).ToList();

            return new PagedResultDto<PatientDetailDto>(
                totalCount,
                ObjectMapper.Map<List<PatientDetailListDto>, List<PatientDetailDto>>(patients)
            );
        }
    }
}
