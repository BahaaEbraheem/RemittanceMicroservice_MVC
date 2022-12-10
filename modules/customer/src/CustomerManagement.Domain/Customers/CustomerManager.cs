//using MicroserviceDemo.CurrencyManagement.Customers;
//using CustomerManagement.Remittances;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace CustomerManagement.Customers
{
   public class CustomerManager : DomainService
    {
        private readonly ICustomerRepository _CustomerRepository;
        //private readonly IRemittanceRepository _remittanceRepository;


        public CustomerManager(ICustomerRepository CustomerRepository
            /*IRemittanceRepository remittanceRepository*/)
        {
            _CustomerRepository = CustomerRepository;
            //_remittanceRepository = remittanceRepository;
        }



        public Task IsCustomerUsedBeforInRemittance(Guid id)
        {
            Check.NotNull(id, nameof(id));
            //var remittancequeryable = _remittanceRepository.GetQueryableAsync().Result.ToList();
            //var remittance = remittancequeryable.Where(a =>( a.SenderBy == id || a.ReceiverBy==id) && a.IsDeleted == false).FirstOrDefault();
            //if (remittance != null)
            //{
            //    var firstName= _CustomerRepository.GetAsync(id).Result.FirstName;
            //    var lastName= _CustomerRepository.GetAsync(id).Result.LastName;
            //    var customerName=firstName +" "+ lastName;
            //    throw new CustomerAlreadyUsedInRemittanceException(customerName);
            //}
            return Task.CompletedTask;
        }

    }
}
