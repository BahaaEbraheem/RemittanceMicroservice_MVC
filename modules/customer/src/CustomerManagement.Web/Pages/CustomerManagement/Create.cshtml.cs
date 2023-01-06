using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using CustomerManagement.Customers;
using CustomerManagement.Customers.Dtos;
using CustomerManagement.Web.Pages;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using static MsDemo.Shared.Enums.Enums;

namespace CustomerManagement.Web.Pages.CustomerManagement
{
    public class CreateModel : CustomerManagementPageModel
    {
        private readonly ICustomerAppService _CustomerAppService;


        [BindProperty]
        public CustomerCreateViewModel Customer { get; set; } = new CustomerCreateViewModel();
        public CreateModel(ICustomerAppService CustomerAppService)
        {
            _CustomerAppService = CustomerAppService;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var CreateUpdateCustomerDto = ObjectMapper.Map<CustomerCreateViewModel, CreateUpdateCustomerDto>(Customer);

            await _CustomerAppService.CreateAsync(CreateUpdateCustomerDto);

            return NoContent();
        }
        public class CustomerCreateViewModel
        {

            [Required]
            public string FirstName { get; set; }
            [Required]

            public string LastName { get; set; }
            [Required]

            public string FatherName { get; set; }
            [Required]

            public string MotherName { get; set; }
            [Required]
            public DateTime BirthDate { get; set; }

            [Required]

            public string Phone { get; set; }

            public string Address { get; set; }
            [Required]

            public Gender Gender { get; set; }
            [HiddenInput]
            public DateTime? LastModificationTime { get; set; }
            [HiddenInput]

            public Guid? LastModifierId { get; set; }
            [HiddenInput]

            public DateTime CreationTime { get; set; }
            [HiddenInput]

            public Guid? CreatorId { get; set; }

        }
    }
}