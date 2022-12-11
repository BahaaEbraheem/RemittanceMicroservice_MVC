import { Injectable } from '@angular/core';
import { RestService } from '@abp/ng.core';

@Injectable({
  providedIn: 'root',
})
export class RemittanceManagementService {
  apiName = 'RemittanceManagement';

  constructor(private restService: RestService) {}

  sample() {
    return this.restService.request<void, any>(
      { method: 'GET', url: '/api/RemittanceManagement/sample' },
      { apiName: this.apiName }
    );
  }
}
