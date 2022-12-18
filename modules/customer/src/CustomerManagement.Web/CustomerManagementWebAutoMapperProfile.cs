using AutoMapper;
using CustomerManagement.Customers.Dtos;
using static CustomerManagement.Web.Pages.CustomerManagement.CreateModel;
using static CustomerManagement.Web.Pages.CustomerManagement.UpdateModel;

namespace CustomerManagement.Web;

public class CustomerManagementWebAutoMapperProfile : Profile
{
    public CustomerManagementWebAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<CustomerDto, CreateUpdateCustomerDto>();
        CreateMap<CreateUpdateCustomerDto, CustomerCreateViewModel>();


        CreateMap<CustomerCreateViewModel, CreateUpdateCustomerDto>()
            
            ;
        CreateMap<CustomerDto, CustomerUpdateViewModel>();
    }
}
