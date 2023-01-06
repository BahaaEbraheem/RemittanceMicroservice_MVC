using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using RemittanceManagement.Remittances;
using MsDemo.Shared.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using static MsDemo.Shared.Enums.Enums;

namespace RemittanceManagement.Web.Pages.RemittanceManagement;

    public class CreateModel : RemittanceManagementPageModel
{
        private readonly IRemittanceAppService _remittanceAppService;


        [BindProperty]
        public RemittanceCreateViewModel Remittance { get; set; } = new RemittanceCreateViewModel();

    public List<SelectListItem> CustomerListItems { get; set; } 
    public ListResultDto<CustomerLookupDto> CustomerList { get; set; }


    public CreateModel(IRemittanceAppService remittanceAppService)
        {
        _remittanceAppService = remittanceAppService;
        }



    public async void OnGet()
    {
        CustomerListItems = new List<SelectListItem>();
        CustomerList =await _remittanceAppService.GetCustomerLookupAsync();
        foreach (var customer in CustomerList.Items)
        {
           var item= new SelectListItem { Value = customer.Id.ToString(), Text = customer.FirstName+" "+customer.FatherName+" "+customer.LastName };
            CustomerListItems.Add(item);
        }
      


    }



    public async Task<IActionResult> OnPostAsync()
        {
            var createRemittanceDto = ObjectMapper.Map<RemittanceCreateViewModel, CreateRemittanceDto>(Remittance);

            await _remittanceAppService.CreateAsync(createRemittanceDto);

            return NoContent();
        }
        public class RemittanceCreateViewModel
    {

        [Required]
        public double Amount { get; set; }

        [Required]
        public RemittanceType Type { get; set; }
        //  public string SerialNumber { get; set; }

        //[Required]

        //public Guid? CreatorId { get; set; }
        //public DateTime CreationTime { get; set; }

        //public Guid? ApprovedBy { get; set; }

        //public DateTime? ApprovedDate { get; set; }
        //public Guid? ReleasedBy { get; set; }
        //public DateTime? ReleasedDate { get; set; }
        [Required]
        [SelectItems(nameof(CustomerListItems))]
        public Guid SenderBy { get; set; }
      //  public string SenderName { get; set; }
        //public Guid? ReceiverBy { get; set; }
        [Required]
        public string ReceiverFullName { get; set; }
        //public string ReceiverName { get; set; }

        [Required]
        public Guid CurrencyId { get; set; }


        public string CurrencyName { get; set; }
       // public Remittance_Status State { get; set; }
        //[HiddenInput]
        //    public DateTime? LastModificationTime { get; set; }
        //    [HiddenInput]

        //    public Guid? LastModifierId { get; set; }
        //    [HiddenInput]

        //    public DateTime CreationTime { get; set; }
        //    [HiddenInput]

        //    public Guid? CreatorId { get; set; }

        }
    }
