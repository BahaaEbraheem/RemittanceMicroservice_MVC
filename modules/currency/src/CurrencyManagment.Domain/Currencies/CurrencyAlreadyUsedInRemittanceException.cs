using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace CurrencyManagment.Currencies
{
   public class CurrencyAlreadyUsedInRemittanceException : BusinessException
    {
        public CurrencyAlreadyUsedInRemittanceException(string remittanceSerial)
            : base(CurrencyManagmentErrorCodes.CurrencyAlreadyUsedInRemittance)
        {
            WithData("remittanceSerial", remittanceSerial);
        }
    }

}
