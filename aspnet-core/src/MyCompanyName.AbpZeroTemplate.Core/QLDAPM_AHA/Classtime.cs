using Abp.Domain.Entities.Auditing;
using Abp.Organizations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyName.AbpZeroTemplate.QLDAPM_AHA
{
    public class Classtime : FullAuditedEntity
    {
        [ForeignKey("OrganizationUnitId")]
        public virtual OrganizationUnit OrganizationUnit { get; set; }
        public virtual long OrganizationUnitId { get; set; }

        [Required]
        public virtual DateTime StartTime{ get; set; }
        [Required]
        public virtual DateTime EndTime { get; set; }
    }
}
