using Abp.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA
{
    public class ClasstimeAppService : AbpZeroTemplateAppServiceBase, IClasstimeAppService
    {
        private readonly IRepository<Classtime> _classtimeRepository;

        public ClasstimeAppService(IRepository<Classtime> classtimeRepository)
        {
            _classtimeRepository = classtimeRepository;
        }

        public Task CreateClasstime(CreateClasstimeInput input)
        {
            Classtime classtime = new Classtime
            {
                OrganizationUnitId = input.OrganizationUnitId,
                StartTime = input.StartTime,
                EndTime = input.EndTime
            };
            return _classtimeRepository.InsertAsync(classtime);
        }
        public async Task UpdateClasstime(UpdateClasstimeInput input)
        {
            var classtime = await _classtimeRepository.GetAll().FirstOrDefaultAsync(p => p.OrganizationUnitId == input.OrganizationUnitId);
            if (classtime == null)
            {
                classtime = new Classtime();
                classtime.OrganizationUnitId = input.OrganizationUnitId;
                classtime.StartTime = input.StartTime;
                classtime.EndTime = input.EndTime;
                await _classtimeRepository.InsertAsync(classtime);
                return;
            }
            classtime.OrganizationUnitId = input.OrganizationUnitId;
            classtime.StartTime = input.StartTime;
            classtime.EndTime = input.EndTime;

            await _classtimeRepository.UpdateAsync(classtime);
        }

        public Task<ClasstimeDto> GetClasstimeById(long classId)
        {
            var query = _classtimeRepository.GetAll().FirstOrDefault(p => p.OrganizationUnitId == classId);
            return Task.FromResult(ObjectMapper.Map<ClasstimeDto>(query));
        }
    }
}
