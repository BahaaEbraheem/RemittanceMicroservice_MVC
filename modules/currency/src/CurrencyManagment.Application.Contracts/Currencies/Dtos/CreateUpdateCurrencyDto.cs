﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Auditing;
using Volo.Abp.Data;

namespace CurrencyManagment.Currencies.Dtos
{
   public class CreateUpdateCurrencyDto
    {

        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }
        public string Code { get; set; }


    }
}
