import { ModuleWithProviders, NgModule } from '@angular/core';
import { CURRENCY_MANAGMENT_ROUTE_PROVIDERS } from './providers/route.provider';

@NgModule()
export class CurrencyManagmentConfigModule {
  static forRoot(): ModuleWithProviders<CurrencyManagmentConfigModule> {
    return {
      ngModule: CurrencyManagmentConfigModule,
      providers: [CURRENCY_MANAGMENT_ROUTE_PROVIDERS],
    };
  }
}
