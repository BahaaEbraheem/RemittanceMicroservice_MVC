﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CurrencyManagment.Currencies.Dtos
{
    public class CreateCurrencyDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Symbol { get; set; }
        public string Code { get; set; }
    }
}
