using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace SurezeApp.Patients
{
    public interface IPatientService
    {
        Task<PagedResultDto<PatientDetailDto>> GetPatientListAsync(GetPatientListDto getPatientListDto);
    }
}
