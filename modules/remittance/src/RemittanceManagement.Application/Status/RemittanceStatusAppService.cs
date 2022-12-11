using RemittanceManagement.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using RemittanceManagement.Permissions;
using Microsoft.AspNetCore.Authorization;
using AutoMapper;
using Volo.Abp.ObjectMapping;
using Volo.Abp.DependencyInjection;
using AutoMapper.Internal.Mappers;
using RemittanceManagement.Status.Dtos;
using RemittanceManagement.Remittances;

namespace RemittanceManagement.Status
{
    public class RemittanceStatusAppService :
        CrudAppService<
               RemittanceStatus, //The customer entity
            RemittanceStatusDto, //Used to show customers
            Guid, //Primary key of the customer entity
            RemittanceStatusPagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateRemittanceStatusDto>, //Used to create/update a customer
        IRemittanceStatusAppService //implement the IcustomerAppService
    {
        private readonly IRemittanceRepository _remittanceRepository;
        private readonly IRemittanceStatusRepository _remittanceStatusRepository;
        public RemittanceStatusAppService(IRepository<RemittanceStatus, Guid> repository,
            IRemittanceRepository remittanceRepository,
            IRemittanceStatusRepository remittanceStatusRepository)
            : base(repository)
        {
            _remittanceRepository = remittanceRepository;
            _remittanceStatusRepository = remittanceStatusRepository;
        }
  
    }
}




