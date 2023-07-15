using SurezeApp.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using Microsoft.EntityFrameworkCore;

namespace SurezeApp.Patients
{
    public class EfCorePatientRepository : EfCoreRepository<SurezeAppDbContext, PatientDetail, Guid>, IPatientRepository
    {
        public EfCorePatientRepository(
            IDbContextProvider<SurezeAppDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        public async Task<List<PatientDetail>> GetPatientListAsync(int skipCount, int maxResultCount, string sorting, string filter = null)
        {
            string param = filter != "" ? filter : " ";

            var dbSet = await GetDbSetAsync();
            return await dbSet
                .WhereIf(
                    !param.IsNullOrWhiteSpace(),
                    author => (author.FirstName.ToLower().Contains(param) || author.LastName.ToLower().Contains(param))
                    )
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
        }
    }
}
