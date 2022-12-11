using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace RemittanceManagement.Remittances
{
    public class RemittanceAlreadyApprovedException : BusinessException
    {
        public RemittanceAlreadyApprovedException(): base(RemittanceManagementErrorCodes.RemittanceAlreadyApproved)
        {
            //WithData( );
        }
    }
}
