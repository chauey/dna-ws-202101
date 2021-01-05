import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'CodingChallenge',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44347',
    redirectUri: baseUrl,
    clientId: 'CodingChallenge_App',
    responseType: 'code',
    scope: 'offline_access CodingChallenge',
  },
  apis: {
    default: {
      url: 'https://localhost:44373',
      rootNamespace: 'Dna.CodingChallenge',
    },
  },
} as Environment;
