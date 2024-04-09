using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyCompanyName.AbpZeroTemplate.QLDAPM_AHA.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA
{
    public interface IClassroomAppService : IApplicationService
    {
        ListResultDto<ClassroomListDto> GetClassroom(GetClassroomInput input);

        ClassroomListDto GetClassroomById(EntityDto<int> input);
        Task CreateClassroom(CreateClassroomInput input);

        Task EditClassroom(EditClassroomInput input);
        Task DeleteClassroom(EntityDto<int> input);
    }
}
