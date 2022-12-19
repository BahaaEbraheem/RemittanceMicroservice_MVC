using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CustomerManagement.Customers;
using CustomerManagement.Customers.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace CustomerManagement.Customers;
[EnableCors]
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

    [HttpGet]
    [Route("CreateAsync")]

    public Task<CustomerDto> CreateAsync(CreateUpdateCustomerDto input)
    {
        return _customerAppService.CreateAsync(input);
    }
    [HttpGet("DeleteAsync")]

    public Task DeleteAsync(Guid id)
    {
        return _customerAppService.DeleteAsync(id);
    }
    [HttpGet]
    [Route("GetAllAsync")]
    public Task<List<CustomerDto>> GetAllAsync()
    {
        return _customerAppService.GetAllAsync();
    }

    [HttpGet]
    [Route("GetAsync")]

    public Task<CustomerDto> GetAsync(Guid id)
    {
        return  _customerAppService.GetAsync(id);
    }
    [HttpGet("GetListAsync")]
    public virtual async Task<PagedResultDto<CustomerDto>> GetListAsync(CustomerPagedAndSortedResultRequestDto input)
    {
        return await  _customerAppService.GetListAsync(input);
    }

    [HttpGet]
    [Route("GetFromReposListAsync")]
    public Task<List<CustomerDto>> GetFromReposListAsync(int skipCount, int maxResultCount, string sorting, CustomerDto filter)
    {
        return _customerAppService.GetFromReposListAsync(skipCount, maxResultCount, sorting, filter);
    }
    [HttpGet]
    [Route("GetTotalCountAsync")]
    public Task<int> GetTotalCountAsync(CustomerDto filter)
    {
        return _customerAppService.GetTotalCountAsync(filter);
    }

    [HttpGet]
    [Route("UpdateAsync")]

    public Task<CustomerDto> UpdateAsync(Guid id, CreateUpdateCustomerDto input)
    {
        return _customerAppService.UpdateAsync(id,input);
    }
}
