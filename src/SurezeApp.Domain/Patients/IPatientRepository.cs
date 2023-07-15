using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace SurezeApp.Patients
{
    public interface IPatientRepository : IRepository<PatientDetail, Guid>
    {
        Task<List<PatientDetail>> GetPatientListAsync(
            int skipCount,
            int maxResultCount,
            string sorting,
            string filter = null
        );
    }
}
