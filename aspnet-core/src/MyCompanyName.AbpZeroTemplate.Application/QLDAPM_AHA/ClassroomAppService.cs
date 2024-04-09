using Abp.Application.Services.Dto;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyCompanyName.AbpZeroTemplate.QLDAPM_AHA.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA
{
    public class ClassroomAppService : AbpZeroTemplateAppServiceBase, IClassroomAppService
    {
        private readonly IRepository<Classroom> _classroomRepository;

        public ClassroomAppService(IRepository<Classroom> classroomRepository)
        {
            _classroomRepository = classroomRepository;
        }

        public ListResultDto<ClassroomListDto> GetClassroom(GetClassroomInput input)
        {
            var query = _classroomRepository.GetAll()
            .WhereIf(
                !string.IsNullOrEmpty(input.Filter),
                p => p.Name.Contains(input.Filter)
            ).ToList();

            return new ListResultDto<ClassroomListDto>(ObjectMapper.Map<List<ClassroomListDto>>(query));

        }
        public ClassroomListDto GetClassroomById(EntityDto<int> input)
        {
            var classroom = _classroomRepository.GetAll().FirstOrDefault(p => p.Id == input.Id);
            return ObjectMapper.Map<ClassroomListDto>(classroom);
        }

        public async Task EditClassroom(EditClassroomInput input)
        {
            var classroom = await _classroomRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, classroom);
            await _classroomRepository.UpdateAsync(classroom);
        }

        public async Task CreateClassroom(CreateClassroomInput input)
        {
            var classroom = ObjectMapper.Map<Classroom>(input);
            await _classroomRepository.InsertAsync(classroom);
        }

        public async Task DeleteClassroom(EntityDto<int> input)
        {
            await _classroomRepository.DeleteAsync(input.Id);
        }
    }
}
