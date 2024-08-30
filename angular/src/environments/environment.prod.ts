import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

const oAuthConfig = {
  issuer: 'https://localhost:44375/',
  redirectUri: baseUrl,
  clientId: 'StoreManagementDemo_App',
  responseType: 'code',
  scope: 'offline_access StoreManagementDemo',
  requireHttps: true,
};

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'StoreManagementDemo',
  },
  oAuthConfig,
  apis: {
    default: {
      url: 'https://localhost:44375',
      rootNamespace: 'Acme.StoreManagementDemo',
    },
    AbpAccountPublic: {
      url: oAuthConfig.issuer,
      rootNamespace: 'AbpAccountPublic',
    },
  },
  remoteEnv: {
    url: '/getEnvConfig',
    mergeStrategy: 'deepmerge'
  }
} as Environment;
