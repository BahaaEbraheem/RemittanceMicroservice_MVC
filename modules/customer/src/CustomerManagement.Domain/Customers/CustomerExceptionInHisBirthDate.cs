using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace CustomerManagement.Customers
{
    public class CustomerExceptionInHisBirthDate : BusinessException
    {
        public CustomerExceptionInHisBirthDate(DateTime birthDate): base(CustomerManagementErrorCodes.BirthDateExeption)
        {
            WithData("birthDate", birthDate);
        }
    }
}
