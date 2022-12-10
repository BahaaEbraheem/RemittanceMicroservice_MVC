using AutoMapper;
using CurrencyManagment.Currencies;
using CurrencyManagment.Currencies.Dtos;

namespace CurrencyManagment;

public class CurrencyManagmentWebAutoMapperProfile : Profile
{
    public CurrencyManagmentWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.

        CreateMap<Currency, CurrencyDto>();
        CreateMap<CreateUpdateCurrencyDto, Currency>();
       // CreateMap<CurrencyPagedAndSortedResultRequestDto, Currency>();
    }
}
