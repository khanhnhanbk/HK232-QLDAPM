using System;

namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA
{
    public class UpdateClasstimeInput
    {
        public long OrganizationUnitId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}