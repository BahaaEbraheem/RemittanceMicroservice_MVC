using System;
using System.Threading.Tasks;
using CurrencyManagment;
using CurrencyManagment.Currencies;
using CurrencyManagment.Currencies.Dtos;
using CurrencyManagment.Samples;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace CurrencyManagment.Currencies;

[RemoteService]
[Area("CurrencyManagment")]
[Route("api/CurrencyManagment/Currency")]
public class CurrencyController : CurrencyManagmentController, ICurrencyAppService
{
    private readonly ICurrencyAppService _currencyAppService;
    public CurrencyController(ICurrencyAppService currencyAppService)
    {
        _currencyAppService = currencyAppService;
    }


    [HttpGet]
    [Route("GetAsync")]
    public virtual async Task<CurrencyDto> GetAsync(Guid id)
    {
        return await _currencyAppService.GetAsync(id);
    }

    [HttpGet]
    [Route("GetListAsync")]
    public virtual async Task<PagedResultDto<CurrencyDto>> GetListAsync(CurrencyPagedAndSortedResultRequestDto input)
    {
        return await _currencyAppService.GetListAsync(input);
    }
    [HttpPost]
    [Route("CreateAsync")]
    public virtual async Task<CurrencyDto> CreateAsync(CreateUpdateCurrencyDto input)
    {
        return await _currencyAppService.CreateAsync(input);
    }
    [HttpPut]
    [Route("UpdateAsync")]
    public virtual async Task<CurrencyDto> UpdateAsync(Guid id, CreateUpdateCurrencyDto input)

    {
        return await _currencyAppService.UpdateAsync(id, input);
    }
    [HttpDelete]
    [Route("DeleteAsync")]
    public virtual Task DeleteAsync(Guid id)
    {
        return _currencyAppService.DeleteAsync(id);
    }


}
