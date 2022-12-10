import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'CustomerManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44398/',
    redirectUri: baseUrl,
    clientId: 'CustomerManagement_App',
    responseType: 'code',
    scope: 'offline_access CustomerManagement',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44398',
      rootNamespace: 'CustomerManagement',
    },
    CustomerManagement: {
      url: 'https://localhost:44396',
      rootNamespace: 'CustomerManagement',
    },
  },
} as Environment;
