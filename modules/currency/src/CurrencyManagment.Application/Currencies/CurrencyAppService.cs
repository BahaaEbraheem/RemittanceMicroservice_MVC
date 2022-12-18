using CurrencyManagment.Currencies;
using CurrencyManagment.Currencies.Dtos;
using CurrencyManagment.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using CurrencyManagment.Permissions;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Volo.Abp.ObjectMapping;
using Volo.Abp.DependencyInjection;
using static System.Reflection.Metadata.BlobBuilder;
//using Volo.Abp.SettingManagement;
using Volo.Abp;
using System.Xml.Linq;
using System.Reflection;
using static CurrencyManagment.Permissions.CurrencyManagmentPermissions;
//using Currency.Remittances;

namespace CurrencyManagment.Currencies
{
    //  [Authorize(CurrencyManagmentPermissions.Currencies.Default)]
   
    public class CurrencyAppService :
        CrudAppService<
               Currency, //The Currency entity
            CurrencyDto, //Used to show Currencies
            Guid, //Primary key of the Currency entity
            CurrencyPagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCurrencyDto>, //Used to create/update a Currency
        ICurrencyAppService //implement the ICurrencyAppService
    {
        private readonly ICurrencyRepository _currencyRepository;
        //private readonly IRemittanceAppService _remittanceAppService;
        private readonly CurrencyManager _currencyManager;
        public CurrencyAppService(IRepository<Currency, Guid> repository,
            ICurrencyRepository currencyRepository,
            //IRemittanceAppService remittanceAppService,
            CurrencyManager currencyManager)
    : base(repository)
        {
            _currencyRepository = currencyRepository;
            _currencyManager = currencyManager;
            //_remittanceAppService = remittanceAppService;
        }



        public override async Task<PagedResultDto<CurrencyDto>> GetListAsync(CurrencyPagedAndSortedResultRequestDto input)
        {
           
            var filter = ObjectMapper.Map<CurrencyPagedAndSortedResultRequestDto, CurrencyDto>(input);
            var sorting = (string.IsNullOrEmpty(input.Sorting) ? "Name DESC" : input.Sorting).Replace("ShortName", "Name");

            var currencies =await GetFromReposListAsync(input.SkipCount, input.MaxResultCount, sorting, filter);
            var totalCount =await GetTotalCountAsync(filter);
            return new  PagedResultDto<CurrencyDto>( totalCount, currencies);
        }




      //  [Authorize(CurrencyManagmentPermissions.Currencies.Create)]
        public override async Task<CurrencyDto> CreateAsync(CreateUpdateCurrencyDto input)
        {
            if (input == null)
            {
                throw new ArgumentNullException("");
            }
            Check.NotNullOrWhiteSpace(input.Name, nameof(input.Name));
            Check.NotNullOrWhiteSpace(input.Symbol, nameof(input.Symbol));
            var existingCurrency = FindByNameAndSymbolAsync(input.Name, input.Symbol).Result;
            if (existingCurrency != null)
            {
                throw new CurrencyAlreadyExistsException(existingCurrency.Name);
            }
            return await base.CreateAsync(input);
        }




      //  [Authorize(CurrencyManagmentPermissions.Currencies.Edit)]
        public override async Task<CurrencyDto> UpdateAsync(Guid id, CreateUpdateCurrencyDto input)
        {

            if (input == null)
            {
                throw new ArgumentNullException("");
            }
            Check.NotNullOrWhiteSpace(id.ToString(), nameof(id));
            //check if currency exist befor in tables
            var existingCurrency = await FindByNameAndSymbolAsync(input.Name, input.Symbol);
            if ((existingCurrency != null && !existingCurrency.Name.Contains(input.Name))
               || (existingCurrency != null && !existingCurrency.Symbol.Contains(input.Symbol)))
            {
                throw new CurrencyAlreadyExistsException(existingCurrency.Name);
            }
            return await base.UpdateAsync(id, input);
        }



      //  [Authorize(CurrencyManagmentPermissions.Currencies.Delete)]
        public override Task DeleteAsync(Guid id)
        {
            //check if this currency using by any remittance
             _currencyManager.IsCurrencyUsedBeforInRemittance(id);
            return base.DeleteAsync(id);
        }

        public async Task<CurrencyDto> FindByNameAndSymbolAsync(string name, string symbol)
        {
            var currencyDto = await _currencyRepository.FindByNameAndSymbolAsync(name, symbol);
           return ObjectMapper.Map<Currency, CurrencyDto>(currencyDto);
        }

     

        public async Task<int> GetTotalCountAsync(CurrencyDto filter)
        {
            return await _currencyRepository.GetTotalCountFromReposAsync(
                ObjectMapper.Map<CurrencyDto,Currency>(filter));
        }

        public  async Task<List<CurrencyDto>> GetAllAsync()
        {
              return  ObjectMapper.Map<List<Currency>, List<CurrencyDto>>(await _currencyRepository.GetAllAsync());
        }

      public async Task<List<CurrencyDto>> GetFromReposListAsync(int skipCount, int maxResultCount, string sorting, CurrencyDto filter)
        {
            var currencies = new List<Currency>();
            //if (filter.Code == null && filter.Name==null && filter.Symbol==null)
            //{
            //     currencies =  _currencyRepository.GetAllAsync();
            //}
            //else
            //{
            var filter_ = ObjectMapper.Map<CurrencyDto, Currency>(filter);
            currencies =await _currencyRepository.GetFromReposListAsync(skipCount, maxResultCount, sorting, filter_);

            //}
           return  ObjectMapper.Map<List<Currency>, List<CurrencyDto>>(currencies);
        }
    }
}


