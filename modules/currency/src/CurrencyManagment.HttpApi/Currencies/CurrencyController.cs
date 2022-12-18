using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Xml.Linq;
using CurrencyManagment;
using CurrencyManagment.Currencies;
using CurrencyManagment.Currencies.Dtos;
using CurrencyManagment.Samples;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
namespace CurrencyManagment.Currencies;
//[ApiController]
[Area(CurrencyManagmentRemoteServiceConsts.ModuleName)]
[RemoteService(Name = CurrencyManagmentRemoteServiceConsts.RemoteServiceName)]
[Route("api/CurrencyManagment/currency")]


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

    [HttpGet("GetListAsync")]

    public virtual async Task<PagedResultDto<CurrencyDto>> GetListAsync( CurrencyPagedAndSortedResultRequestDto input)
    {
        return await _currencyAppService.GetListAsync(input);
    }







    [HttpGet]
    [Route("CreateAsync")]
    public virtual async Task<CurrencyDto> CreateAsync( CreateUpdateCurrencyDto input)
    {
        return await _currencyAppService.CreateAsync(input);
    }
    [HttpGet]
    [Route("UpdateAsync")]
    public  async Task<CurrencyDto> UpdateAsync(Guid id,  CreateUpdateCurrencyDto input)

    {
        return await _currencyAppService.UpdateAsync(id, input);
    }
    [HttpDelete]
    [Route("DeleteAsync")]
    public virtual Task DeleteAsync(Guid id)
    {
        return _currencyAppService.DeleteAsync(id);
    }
    [HttpGet]
    [Route("FindByNameAndSymbolAsync")]
    public Task<CurrencyDto> FindByNameAndSymbolAsync(string name, string symbol)
    {
        return _currencyAppService.FindByNameAndSymbolAsync(name, symbol);
    }

    [HttpGet]
    [Route("GetAllAsync")]
    public async Task<List<CurrencyDto>> GetAllAsync()
    {
        return await _currencyAppService.GetAllAsync();
    }


    //[HttpGet]
    //[Route("GetFromReposListAsync")]
    //public Task<List<CurrencyDto>> GetFromReposListAsync(int skipCount, int maxResultCount, string sorting, [FromQuery] CurrencyDto filter)
    //{
    //    return _currencyAppService.GetFromReposListAsync(skipCount, maxResultCount, sorting, filter);
    //}
    //[HttpGet]
    //[Route("GetTotalCountAsync")]
    //public Task<int> GetTotalCountAsync(CurrencyDto filter)
    //{
    //    return _currencyAppService.GetTotalCountAsync(filter);
    //}
}
