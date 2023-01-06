﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;
using static MsDemo.Shared.Enums.Enums;

namespace CustomerManagement.Customers.Dtos
{
      public class CustomerDto : AuditedEntityDto<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }
    
        public DateTime BirthDate { get; set; }


        public string Phone { get; set; }

        public string Address { get; set; }

       
        public Gender Gender { get; set; }

    }
}
