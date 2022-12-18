using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CurrencyManagment.Currencies.Dtos
{
      public class CurrencyDto : AuditedEntityDto<Guid>
    {
        public new Guid Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Code { get; set; }



    }
}
