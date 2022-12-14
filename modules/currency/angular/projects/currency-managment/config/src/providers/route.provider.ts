import { eLayoutType, RoutesService } from '@abp/ng.core';
import { APP_INITIALIZER } from '@angular/core';
import { eCurrencyManagmentRouteNames } from '../enums/route-names';

export const CURRENCY_MANAGMENT_ROUTE_PROVIDERS = [
  {
    provide: APP_INITIALIZER,
    useFactory: configureRoutes,
    deps: [RoutesService],
    multi: true,
  },
];

export function configureRoutes(routesService: RoutesService) {
  return () => {
    routesService.add([
      {
        path: '/currency-managment',
        name: eCurrencyManagmentRouteNames.CurrencyManagment,
        iconClass: 'fas fa-book',
        layout: eLayoutType.application,
        order: 3,
      },
    ]);
  };
}
