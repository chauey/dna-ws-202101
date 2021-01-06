import { mapEnumToOptions } from '@abp/ng.core';

export enum RatingType {
  Undefined = 0,
  G = 1,
  NC17 = 2,
  NR = 3,
  PG = 4,
  PG13 = 5,
  R = 6,
  TV14 = 7,
  TVG = 8,
  TVMA = 9,
  TVPG = 10,
  TVY = 11,
  TVY7 = 12,
  TVY7FV = 13,
  UR = 14,
}

export const ratingTypeOptions = mapEnumToOptions(RatingType);
