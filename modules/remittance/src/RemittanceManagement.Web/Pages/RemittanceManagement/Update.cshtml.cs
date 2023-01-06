using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using CurrencyManagment.Currencies;
using CurrencyManagment.Currencies.Dtos;
using Microsoft.AspNetCore.Mvc;
using RemittanceManagement.Remittances;
using MsDemo.Shared.Dtos;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;
using Volo.Abp.ObjectMapping;
using static RemittanceManagement.Permissions.RemittanceManagementPermissions;
using static MsDemo.Shared.Enums.Enums;

namespace RemittanceManagement.Web.Pages.RemittanceManagement;

    public class UpdateModel : RemittanceManagementPageModel
{
   

        [BindProperty]
      //  public CreateUpdateCurrencyDto Currency { get; set; }
        public RemittanceUpdateViewModel Remittance { get; set; } = new RemittanceUpdateViewModel();

    private readonly IRemittanceAppService _remittanceAppService;

    public UpdateModel(IRemittanceAppService remittanceAppService)
        {
        _remittanceAppService = remittanceAppService;
        }

        public async Task<ActionResult> OnGetAsync(Guid id)
    {

            var remittanceDto = await _remittanceAppService.GetAsync(id);
        Remittance = ObjectMapper.Map<RemittanceDto, RemittanceUpdateViewModel>(remittanceDto);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _remittanceAppService.UpdateAsync(Remittance.Id, new UpdateRemittanceDto()
            {
                Amount = Remittance.Amount,
                Type = (RemittanceType)Remittance.Type,
                SenderBy=Remittance.SenderBy,
                CurrencyId= (Guid)Remittance.CurrencyId,
                State = (Remittance_Status)Remittance.State,
            });
            return NoContent();
        }
        public class RemittanceUpdateViewModel
    {
            [HiddenInput]
            [Required]
            public Guid Id { get; set; }
        public double Amount { get; set; }
        public double TotalAmount { get; set; }

        public RemittanceType Type { get; set; }
        public string SerialNumber { get; set; }

        public Guid? ApprovedBy { get; set; }

        public DateTime? ApprovedDate { get; set; }
        public Guid? ReleasedBy { get; set; }
        public DateTime? ReleasedDate { get; set; }

        public Guid SenderBy { get; set; }

        public string SenderName { get; set; }

        public Guid? ReceiverBy { get; set; }
        public string ReceiverFullName { get; set; }
        public string ReceiverName { get; set; }

        public Guid? CurrencyId { get; set; }
        public string CurrencyName { get; set; }


        public Remittance_Status State { get; set; }
        public DateTime? StatusDate { get; set; }

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
