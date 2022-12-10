using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace CurrencyManagment.Currencies
{
   public class CurrencyAlreadyExistsException : BusinessException
    {
        public CurrencyAlreadyExistsException(string name)
            : base(CurrencyManagmentErrorCodes.CurrencyAlreadyExists)
        {
            WithData("name", name);
        }
    }

}
