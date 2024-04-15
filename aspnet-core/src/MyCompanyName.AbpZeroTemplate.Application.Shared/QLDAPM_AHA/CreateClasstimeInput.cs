using System;

namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA
{
    public class CreateClasstimeInput
    {
        public long OrganizationUnitId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}