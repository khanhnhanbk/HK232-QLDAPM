using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA
{
    public interface IClasstimeAppService : IApplicationService
    {
        Task CreateClasstime(CreateClasstimeInput input);
        Task UpdateClasstime(UpdateClasstimeInput input);

        Task<ClasstimeDto> GetClasstimeById(long classId);
    }
}
