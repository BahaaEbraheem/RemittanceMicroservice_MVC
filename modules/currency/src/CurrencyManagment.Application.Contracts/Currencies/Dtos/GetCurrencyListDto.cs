using Volo.Abp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurrencyManagment.Currencies.Dtos
{
   public class GetCurrencyListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
