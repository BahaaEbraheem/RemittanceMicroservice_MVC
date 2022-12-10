using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using CurrencyManagment.Currencies;
using CurrencyManagment.Currencies.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CurrencyManagment.Web.Pages.CurrencyManagment
{
    public class UpdateModel : CurrencyManagmentPageModel
    {
   

        [BindProperty]
      //  public CreateUpdateCurrencyDto Currency { get; set; }
        public CurrencyUpdateViewModel Currency { get; set; } = new CurrencyUpdateViewModel();

        private readonly ICurrencyAppService _currencyAppService;

        public UpdateModel(ICurrencyAppService currencyAppService)
        {
            _currencyAppService = currencyAppService;
        }

        public async Task<ActionResult> OnGetAsync(Guid id)
        {

            var currencyDto = await _currencyAppService.GetAsync(id);
            Currency = ObjectMapper.Map<CurrencyDto, CurrencyUpdateViewModel>(currencyDto);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _currencyAppService.UpdateAsync(Currency.Id, new CreateUpdateCurrencyDto()
            {
                Name = Currency.Name,
                Symbol = Currency.Symbol,
                Code = Currency.Code

            });
            return NoContent();
        }
        public class CurrencyUpdateViewModel
        {
            [HiddenInput]
            [Required]
            public Guid Id { get; set; }
            [Required]
            public string Name { get; set; }

            [Required]
            public string Symbol { get; set; }
            public string Code { get; set; }
      

        }
    }
}