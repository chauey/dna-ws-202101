import { mapEnumToOptions } from '@abp/ng.core';

export enum ShowType {
  Undefined = 0,
  Movie = 1,
  TvShow = 2,
}

export const showTypeOptions = mapEnumToOptions(ShowType);
