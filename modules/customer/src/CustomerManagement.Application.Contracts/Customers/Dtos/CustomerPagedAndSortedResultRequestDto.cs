using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;
using static CustomerManagement.Enums.Enums;

namespace CustomerManagement.Customers.Dtos
{
    public class CustomerPagedAndSortedResultRequestDto:PagedAndSortedResultRequestDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FatherName { get; set; }

        public string MotherName { get; set; }

        //public DateTime BirthDate { get; set; }
   

    }
}
