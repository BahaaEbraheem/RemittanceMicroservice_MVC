import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'CurrencyManagment',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44393/',
    redirectUri: baseUrl,
    clientId: 'CurrencyManagment_App',
    responseType: 'code',
    scope: 'offline_access CurrencyManagment',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44393',
      rootNamespace: 'CurrencyManagment',
    },
    CurrencyManagment: {
      url: 'https://localhost:44339',
      rootNamespace: 'CurrencyManagment',
    },
  },
} as Environment;
