using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace RemittanceManagement.Remittances
{
    public class CustomerDontPassBecauseHisAgeSmallerThan18Exception : BusinessException
    {
        public CustomerDontPassBecauseHisAgeSmallerThan18Exception(string customerName)
            : base(RemittanceManagementErrorCodes.CustomerDontPassBecauseHisAgeSmallerThan18)
        {
            WithData("customerName", customerName);
        }
    
    }
}
