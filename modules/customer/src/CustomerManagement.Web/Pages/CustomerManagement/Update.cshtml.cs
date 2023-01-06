using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using CustomerManagement.Customers;
using CustomerManagement.Customers.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using static MsDemo.Shared.Enums.Enums;

namespace CustomerManagement.Web.Pages.CustomerManagement
{
    public class UpdateModel : CustomerManagementPageModel
    {
   

        [BindProperty]
      //  public CreateUpdateCustomerDto Customer { get; set; }
        public CustomerUpdateViewModel Customer { get; set; } = new CustomerUpdateViewModel();

        private readonly ICustomerAppService _CustomerAppService;

        public UpdateModel(ICustomerAppService CustomerAppService)
        {
            _CustomerAppService = CustomerAppService;
        }

        public async Task<ActionResult> OnGetAsync(Guid id)
        {

            var CustomerDto = await _CustomerAppService.GetAsync(id);
            Customer = ObjectMapper.Map<CustomerDto, CustomerUpdateViewModel>(CustomerDto);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _CustomerAppService.UpdateAsync(Customer.Id, new CreateUpdateCustomerDto()
            {
                FirstName = Customer.FirstName,
                LastName = Customer.LastName,
                FatherName = Customer.FatherName,
                MotherName = Customer.MotherName,
                BirthDate = Customer.BirthDate,
                Phone = Customer.Phone,
                Address = Customer.Address,
                Gender = Customer.Gender,



            });
            return NoContent();
        }
        public class CustomerUpdateViewModel
        {
            [HiddenInput]
            [Required]
            public Guid Id { get; set; }
            [Required]
            public string FirstName { get; set; }
            [Required]

            public string LastName { get; set; }
            [Required]

            public string FatherName { get; set; }
            [Required]

            public string MotherName { get; set; }
            [Required]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            public DateTime BirthDate { get; set; }

            [Required]

            public string Phone { get; set; }

            public string Address { get; set; }
            [Required]

            [EnumDataType(typeof(Gender))]
            public Gender Gender { get; set; }


        }
    }
}