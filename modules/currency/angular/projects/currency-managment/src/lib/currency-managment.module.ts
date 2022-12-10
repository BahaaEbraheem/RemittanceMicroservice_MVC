import { NgModule, NgModuleFactory, ModuleWithProviders } from '@angular/core';
import { CoreModule, LazyModuleFactory } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { CurrencyManagmentComponent } from './components/currency-managment.component';
import { CurrencyManagmentRoutingModule } from './currency-managment-routing.module';

@NgModule({
  declarations: [CurrencyManagmentComponent],
  imports: [CoreModule, ThemeSharedModule, CurrencyManagmentRoutingModule],
  exports: [CurrencyManagmentComponent],
})
export class CurrencyManagmentModule {
  static forChild(): ModuleWithProviders<CurrencyManagmentModule> {
    return {
      ngModule: CurrencyManagmentModule,
      providers: [],
    };
  }

  static forLazy(): NgModuleFactory<CurrencyManagmentModule> {
    return new LazyModuleFactory(CurrencyManagmentModule.forChild());
  }
}
