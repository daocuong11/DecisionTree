import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'DecisionTree',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44364/',
    redirectUri: baseUrl,
    clientId: 'DecisionTree_App',
    responseType: 'code',
    scope: 'offline_access DecisionTree',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44364',
      rootNamespace: 'DecisionTree',
    },
  },
} as Environment;
