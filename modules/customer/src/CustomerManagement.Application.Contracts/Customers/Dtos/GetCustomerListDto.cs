using Volo.Abp.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerManagement.Customers.Dtos
{
   public class GetCustomerListDto : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }
}
