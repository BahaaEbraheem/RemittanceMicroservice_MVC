using AutoMapper;
using CurrencyManagment.Currencies.Dtos;
using CustomerManagement.Customers.Dtos;
using RemittanceManagement.Remittances;
using MsDemo.Shared.Dtos;
using RemittanceManagement.Status;
using RemittanceManagement.Status.Dtos;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Numerics;

namespace RemittanceManagement;

public class RemittanceManagementApplicationAutoMapperProfile : Profile
{
    public RemittanceManagementApplicationAutoMapperProfile()
    {


        //    CreateMap<UserGroup, GroupYearsListDto>()
        //.ForMember(
        //    dest => dest.RegisteredYear,
        //    opt => opt.MapFrom(src =>
        //    {
        //        IEnumerable<string> registeredYears = src.Group.GroupYears.Select(x => x.RegisteredYear);
        //        return registeredYears.ToString();
        //    })
        //);
        CreateMap<Remittance, RemittanceDto>()
             .ForMember(model => model.SenderName, option => option.Ignore())
            .ForMember(model => model.ReceiverName, option => option.Ignore())
            .ForMember(model => model.CurrencyName, option => option.Ignore())
            .ForMember(model => model.State, option => option.Ignore())
            .ForMember(model => model.StatusDate, option => option.Ignore());
        




        CreateMap<RemittanceStatus, RemittanceStatusDto>();


        CreateMap<CreateUpdateRemittanceStatusDto, RemittanceStatus>()
            .ForMember(model => model.IsDeleted, option => option.Ignore())
            .ForMember(model => model.DeleterId, option => option.Ignore())
            .ForMember(model => model.DeletionTime, option => option.Ignore())
            .ForMember(model => model.Id, option => option.Ignore())
                .ForMember(model => model.LastModifierId, option => option.Ignore())
               .ForMember(model => model.CreatorId, option => option.Ignore())
               .ForMember(model => model.CreationTime, option => option.Ignore())
               .ForMember(model => model.LastModificationTime, option => option.Ignore());


        CreateMap<CreateUpdateRemittanceStatusDto, RemittanceStatusDto>()
            .ForMember(model => model.Id, option => option.Ignore())
                .ForMember(model => model.LastModifierId, option => option.Ignore())
               .ForMember(model => model.CreatorId, option => option.Ignore())
               .ForMember(model => model.CreationTime, option => option.Ignore())
               .ForMember(model => model.LastModificationTime, option => option.Ignore());

        CreateMap<GetRemittanceListPagedAndSortedResultRequestDto, Remittance>()
              .ForMember(model => model.ExtraProperties, option => option.Ignore())
               .ForMember(model => model.ConcurrencyStamp, option => option.Ignore())
               .ForMember(model => model.Status, option => option.Ignore());

        CreateMap<RemittanceStatus, RemittanceStatusDto>();

        CreateMap<CurrencyDto, CurrencyLookupDto>();
        CreateMap<CustomerDto, CustomerLookupDto>();
        //CreateMap<ICollection <CurrencyDto>, ICollection<CurrencyLookupDto> >();

        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
