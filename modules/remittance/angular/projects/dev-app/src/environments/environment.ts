import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl: 'http://localhost:4200/',
    name: 'RemittanceManagement',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44374/',
    redirectUri: baseUrl,
    clientId: 'RemittanceManagement_App',
    responseType: 'code',
    scope: 'offline_access RemittanceManagement',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44374',
      rootNamespace: 'RemittanceManagement',
    },
    RemittanceManagement: {
      url: 'https://localhost:44349',
      rootNamespace: 'RemittanceManagement',
    },
  },
} as Environment;
