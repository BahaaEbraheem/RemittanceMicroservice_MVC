using CustomerManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace CustomerManagement.Customers
{
    public class CustomerDontPassBecauseHisAgeSmallerThan18Exception : BusinessException
    {
        public CustomerDontPassBecauseHisAgeSmallerThan18Exception(string customerName)
            : base(CustomerManagementErrorCodes.CustomerDontPassBecauseHisAgeSmallerThan18)
        {
            WithData("customerName", customerName);
        }
    
    }
}
