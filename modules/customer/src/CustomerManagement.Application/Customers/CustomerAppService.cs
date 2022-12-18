using CustomerManagement.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using CustomerManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Volo.Abp.DependencyInjection;
using CustomerManagement.Customers;
using CustomerManagement.Customers.Dtos;
using Volo.Abp.ObjectMapping;
using Volo.Abp.Users;

namespace CustomerManagement.Customers
{
    //[Authorize(CustomerManagementPermissions.Customers.Default)]

    public class CustomerAppService :
        CrudAppService<
               Customer, //The customer entity
            CustomerDto, //Used to show customers
            Guid, //Primary key of the customer entity
            CustomerPagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateCustomerDto>, //Used to create/update a customer
        ICustomerAppService //implement the IcustomerAppService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly CustomerManager _customerManager;
        public CustomerAppService(IRepository<Customer, Guid> repository,
            CustomerManager customerManager,
            ICustomerRepository customerRepository)
            : base(repository)
        {
            _customerManager = customerManager;
            _customerRepository = customerRepository;
        }




        public override async Task<PagedResultDto<CustomerDto>> GetListAsync(CustomerPagedAndSortedResultRequestDto input)
        {
            var filter = ObjectMapper.Map<CustomerPagedAndSortedResultRequestDto, CustomerDto>(input);
            var sorting = (string.IsNullOrEmpty(input.Sorting) ? "FirstName DESC" : input.Sorting).Replace("ShortName", "FirstName");
            var customers = await GetFromReposListAsync(input.SkipCount, input.MaxResultCount, sorting, filter);
            var totalCount = await GetTotalCountAsync(filter);
            return new PagedResultDto<CustomerDto>(totalCount,customers);
        }

       // [Authorize(CustomerManagementPermissions.Customers.Create)]
        public override Task<CustomerDto> CreateAsync(CreateUpdateCustomerDto input)
        {
            try
            {
                if (input!=null)
                {
                    return base.CreateAsync(input);

                }
                throw new ArgumentNullException(nameof(input));

            }
            catch (Exception)
            {

                throw;
            }
        }



      //  [Authorize(CustomerManagementPermissions.Customers.Edit)]
        public override Task<CustomerDto> UpdateAsync(Guid id, CreateUpdateCustomerDto input)
        {
            try
            {
                if (input != null)
                {
                    return base.UpdateAsync(id, input);

                }
                    throw new ArgumentNullException(nameof(input));
            }
            catch (Exception)
            {

                throw;
            }
        }


       // [Authorize(CustomerManagementPermissions.Customers.Delete)]
        public override Task DeleteAsync(Guid id)
        {
            try
            {
                if (!id.Equals(null))
                {
                    _customerManager.IsCustomerUsedBeforInRemittance(id);

                    return base.DeleteAsync(id);
                }
                throw new ArgumentNullException(nameof(id));
            }
            catch (Exception)
            {

                throw;
            }
          
        }



    

        public async Task<List<CustomerDto>> GetFromReposListAsync(int skipCount, int maxResultCount, string sorting, CustomerDto filter)
        {

            return await _customerRepository.GetFromReposListAsync(skipCount, maxResultCount, sorting, filter);
           
        }

        public async Task<int> GetTotalCountAsync(CustomerDto filter)
        {
            return await _customerRepository.GetTotalCountAsync(filter);
        }

        public async Task<List<CustomerDto>> GetAllAsync()
        {
            return ObjectMapper.Map<List<Customer>, List<CustomerDto>>(await _customerRepository.GetAllAsync());
        }
    }
}






