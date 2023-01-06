using AutoMapper;
using RemittanceManagement.Remittances;
using MsDemo.Shared.Dtos;
using RemittanceManagement.Status;
using RemittanceManagement.Status.Dtos;

namespace RemittanceManagement.Web;

public class RemittanceManagementWebAutoMapperProfile : Profile
{
    public RemittanceManagementWebAutoMapperProfile()
    {
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
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
