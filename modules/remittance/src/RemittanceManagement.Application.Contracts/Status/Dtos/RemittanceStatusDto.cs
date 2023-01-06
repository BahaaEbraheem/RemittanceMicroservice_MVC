using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;
using static MsDemo.Shared.Enums.Enums;

namespace RemittanceManagement.Status.Dtos
{
    public class RemittanceStatusDto : AuditedEntityDto<Guid>
    {
        public Guid RemittanceId { get;  set; }
        public Remittance_Status State { get; set; }


    }
}
