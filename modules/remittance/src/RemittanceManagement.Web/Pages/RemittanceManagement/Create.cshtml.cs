using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RemittanceManagement.Remittances;
using RemittanceManagement.Remittances.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using static CustomerManagement.Enums.Enums;

namespace RemittanceManagement.Web.Pages.RemittanceManagement;

    public class CreateModel : RemittanceManagementPageModel
{
        private readonly IRemittanceAppService _remittanceAppService;


        [BindProperty]
        public RemittanceCreateViewModel Remittance { get; set; } = new RemittanceCreateViewModel();
        public CreateModel(IRemittanceAppService remittanceAppService)
        {
        _remittanceAppService = remittanceAppService;
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
        public string SerialNumber { get; set; }

        //[Required]

        public Guid? CreatorId { get; set; }
        public DateTime CreationTime { get; set; }

        public Guid? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }
        public Guid? ReleasedBy { get; set; }
        public DateTime? ReleasedDate { get; set; }
        [Required]
        public Guid SenderBy { get; set; }
        public string SenderName { get; set; }
        public Guid? ReceiverBy { get; set; }
        [Required]
        public string ReceiverFullName { get; set; }
        public string ReceiverName { get; set; }

        [Required]
        public Guid CurrencyId { get; set; }


        public string CurrencyName { get; set; }
        public Remittance_Status State { get; set; }
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
