using JetBrains.Annotations;
using Microsoft.Extensions.Configuration.UserSecrets;
using RemittanceManagement.Remittances;
using RemittanceManagement.Status;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Volo.Abp;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.Domain.Services;
using Volo.Abp.Users;
using static MsDemo.Shared.Enums.Enums;

namespace RemittanceManagement.Status
{
    public class RemitanceStatusManager : DomainService
    {
        private readonly IRemittanceRepository _remittanceRepository;
        private readonly IRemittanceStatusRepository _remittanceStatusRepository;
        private readonly ICurrentUser _currentUser;

        public RemitanceStatusManager(IRemittanceRepository remittanceRepository,
            IRemittanceStatusRepository remittanceStatusRepository, ICurrentUser currentUser)
        {
            _remittanceRepository = remittanceRepository;
            _remittanceStatusRepository = remittanceStatusRepository;
            _currentUser = currentUser;
        }

        public async Task<RemittanceStatus> CreateAsync(Guid remittanceId, Remittance_Status State)
        {

            return await Task.FromResult( new RemittanceStatus(
                 GuidGenerator.Create(),
                 remittanceId, State

            ));
        }

        public  async Task<RemittanceStatus> UpdateAsync(Guid remittanceId)
        {
            Check.NotNullOrWhiteSpace(remittanceId.ToString(), nameof(remittanceId));
            //return last record to this remittance from remittanceStatus
            var LastRemitanceStatusCreation = await _remittanceStatusRepository.FindLastStateToThisRemitanceAsync(remittanceId);
            if (LastRemitanceStatusCreation == null)
            {
                throw new ArgumentNullException();
            }
            return  new RemittanceStatus(
                 GuidGenerator.Create(),
                 remittanceId,
                 LastRemitanceStatusCreation.State
            );

        }

    }
}