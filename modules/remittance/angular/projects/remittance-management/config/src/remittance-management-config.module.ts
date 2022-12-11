import { ModuleWithProviders, NgModule } from '@angular/core';
import { REMITTANCE_MANAGEMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class RemittanceManagementConfigModule {
  static forRoot(): ModuleWithProviders<RemittanceManagementConfigModule> {
    return {
      ngModule: RemittanceManagementConfigModule,
      providers: [REMITTANCE_MANAGEMENT_ROUTE_PROVIDERS],
    };
  }
}
