using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace CustomerManagement.Customers
{
    public class CustomerAlreadyUsedInRemittanceException : BusinessException
    {
        public CustomerAlreadyUsedInRemittanceException(string customerName)
            : base(CustomerManagementErrorCodes.CustomerAlreadyUsedInRemittance)
        {
            WithData("customerName", customerName);
        }
    }
}
