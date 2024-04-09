using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA
{
    public class Classroom : FullAuditedEntity
    {
        public virtual string Name { get; set; }
        public virtual  string Description { get; set; }
        public virtual string Location { get; set; }
        public virtual int Capacity { get; set; }
   
    }
}
