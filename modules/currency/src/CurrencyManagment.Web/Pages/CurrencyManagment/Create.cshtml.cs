using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using CurrencyManagment.Currencies;
using CurrencyManagment.Currencies.Dtos;
using CurrencyManagment.Web.Pages;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace CurrencyManagment.Web.Pages.CurrencyManagment
{
    public class CreateModel : CurrencyManagmentPageModel
    {
        private readonly ICurrencyAppService _currencyAppService;


        [BindProperty]
        public CurrencyCreateViewModel Currency { get; set; } = new CurrencyCreateViewModel();
        public CreateModel(ICurrencyAppService currencyAppService)
        {
            _currencyAppService = currencyAppService;
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var CreateUpdateCurrencyDto = ObjectMapper.Map<CurrencyCreateViewModel, CreateUpdateCurrencyDto>(Currency);

            await _currencyAppService.CreateAsync(CreateUpdateCurrencyDto);

            return NoContent();
        }
        public class CurrencyCreateViewModel
        {

            [Required]
            public string Name { get; set; }

            [Required]
            public string Symbol { get; set; }
            public string Code { get; set; }
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