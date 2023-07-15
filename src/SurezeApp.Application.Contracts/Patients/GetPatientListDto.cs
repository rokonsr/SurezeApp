using Volo.Abp.Application.Dtos;

namespace SurezeApp.Patients
{
    public class GetPatientListDto : PagedAndSortedResultRequestDto
    {
        public string? Filter { get; set; }
    }
}
