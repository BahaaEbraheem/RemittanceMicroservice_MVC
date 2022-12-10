using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Auditing;
using Volo.Abp.Data;

namespace CurrencyManagment.Currencies.Dtos
{
   public class CurrencyPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {

        public string Name { get;  set; }
        public string Symbol { get; set; }
        public string Code { get; set; }
 
    }
}
