﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MsDemo.Shared.Dtos
{
   public class UserLookupDto : EntityDto<Guid>
    {
        public string Name { get; set; }
    }
}
