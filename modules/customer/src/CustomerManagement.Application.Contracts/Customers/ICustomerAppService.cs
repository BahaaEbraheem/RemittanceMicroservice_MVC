using CustomerManagement.Customers.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using static CustomerManagement.Permissions.CustomerManagementPermissions;

namespace CustomerManagement.Customers
{
    public interface ICustomerAppService : IApplicationService,
         ICrudAppService< //Defines CRUD methods
             CustomerDto, //Used to show Customers
             Guid, //Primary key of the currency entity
             CustomerPagedAndSortedResultRequestDto, //Used for paging/sorting
             CreateUpdateCustomerDto> //Used to create/update a currency
    {
        Task<List<CustomerDto>> GetAllAsync();

        //Task<CustomerDto> FindByFullNameAsync(string firstName, string lastName, string fatherName, string motherName);

        Task<List<CustomerDto>> GetFromReposListAsync(
     int skipCount,
        int maxResultCount,
        string sorting,
     CustomerDto filter
 );
        Task<int> GetTotalCountAsync(CustomerDto filter);

    }
}
