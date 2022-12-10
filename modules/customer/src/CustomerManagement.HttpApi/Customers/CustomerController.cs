using System;
using System.Threading.Tasks;
using CustomerManagement.Customers;
using CustomerManagement.Customers.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace CustomerManagement.Customers;

[Area(CustomerManagementRemoteServiceConsts.ModuleName)]
[RemoteService(Name = CustomerManagementRemoteServiceConsts.RemoteServiceName)]
[Route("api/CustomerManagement/customer")]
public class CustomerController : CustomerManagementController, ICustomerAppService
{
    private readonly ICustomerAppService _customerAppService;

    public CustomerController(ICustomerAppService customerAppService)
    {
        _customerAppService = customerAppService;
    }

    [HttpPost]
    [Route("CreateAsync")]

    public Task<CustomerDto> CreateAsync(CreateUpdateCustomerDto input)
    {
        return _customerAppService.CreateAsync(input);
    }
    [HttpDelete]
    [Route("DeleteAsync")]

    public Task DeleteAsync(Guid id)
    {
        return _customerAppService.DeleteAsync(id);
    }

    [HttpGet]
    [Route("GetAsync")]

    public Task<CustomerDto> GetAsync(Guid id)
    {
        return  _customerAppService.GetAsync(id);
    }

    [HttpGet]
    [Route("GetListAsync")]
    public virtual async Task<PagedResultDto<CustomerDto>> GetListAsync(CustomerPagedAndSortedResultRequestDto input)
    {
        return await  _customerAppService.GetListAsync(input);
    }
    [HttpPut]
    [Route("UpdateAsync")]

    public Task<CustomerDto> UpdateAsync(Guid id, CreateUpdateCustomerDto input)
    {
        return _customerAppService.UpdateAsync(id,input);
    }
}
