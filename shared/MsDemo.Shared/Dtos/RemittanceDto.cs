﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;
using static MsDemo.Shared.Enums.Enums;

namespace MsDemo.Shared.Dtos
{
   public class RemittanceDto : AuditedEntityDto<Guid>
    {

        public double Amount { get; set; }
        public double TotalAmount { get; set; }

        public RemittanceType Type { get; set; }
        public string SerialNumber { get;  set; }

        public Guid? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }
        public Guid? ReleasedBy { get; set; }
        public DateTime? ReleasedDate { get; set; }

        public Guid SenderBy { get; set; }

        public string SenderName { get; set; }

        public Guid? ReceiverBy { get; set; }
        public string ReceiverFullName { get; set; }
        public string ReceiverName { get; set; }

        public Guid? CurrencyId { get; set; }
        public string CurrencyName { get; set; }


        public Remittance_Status State { get; set; }
        public DateTime? StatusDate { get; set; }


    }
}
