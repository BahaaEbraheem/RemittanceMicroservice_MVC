using AutoMapper;
using CurrencyManagment.Currencies.Dtos;
using static CurrencyManagment.Web.Pages.CurrencyManagment.CreateModel;
using static CurrencyManagment.Web.Pages.CurrencyManagment.UpdateModel;

namespace CurrencyManagment.Web;

public class CurrencyManagmentWebAutoMapperProfile : Profile
{
    public CurrencyManagmentWebAutoMapperProfile()
    {
        CreateMap<CurrencyDto, CreateUpdateCurrencyDto>();
        CreateMap<CreateUpdateCurrencyDto, CurrencyCreateViewModel>(); 
        CreateMap<CurrencyCreateViewModel, CreateUpdateCurrencyDto>();
        CreateMap<CurrencyDto, CurrencyUpdateViewModel>()
            /*.ForMember(model => model.Id, option => option.Ignore())*/;
        //CreateMap<CurrencyUpdateViewModel, CurrencyDto>()
        //            .ForMember(model => model.LastModifierId, option => option.Ignore())
        //       .ForMember(model => model.CreatorId, option => option.Ignore())
        //       .ForMember(model => model.CreationTime, option => option.Ignore())
        //       .ForMember(model => model.LastModificationTime, option => option.Ignore());
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
