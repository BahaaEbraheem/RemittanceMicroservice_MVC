import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { RemittanceManagementComponent } from './components/remittance-management.component';
import { RemittanceManagementRoutingModule } from './remittance-management-routing.module';

@NgModule({
  declarations: [RemittanceManagementComponent],
  imports: [CoreModule, ThemeSharedModule, RemittanceManagementRoutingModule],
  exports: [RemittanceManagementComponent],
})
export class RemittanceManagementModule {
  static forChild(): ModuleWithProviders<RemittanceManagementModule> {
    return {
      ngModule: RemittanceManagementModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<RemittanceManagementModule> {
    return new LazyModuleFactory(RemittanceManagementModule.forChild());
  }
}
