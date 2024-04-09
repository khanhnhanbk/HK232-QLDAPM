using Abp.Domain.Entities.Auditing;

namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA.Dto
{
    public class ClassroomListDto 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
    }
}