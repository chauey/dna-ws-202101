import type { ShowType } from './show-type.enum';
import type { RatingType } from './rating-type.enum';
import type { AuditedEntityDto } from '@abp/ng.core';

export interface CreateUpdateShowDto {
  type: ShowType;
  title: string;
  director?: string;
  cast?: string;
  dateAdded?: string;
  releaseYear: number;
  rating: RatingType;
  duration?: string;
  listedIn?: string;
  description?: string;
}

export interface ShowDto extends AuditedEntityDto<number> {
  type: ShowType;
  title?: string;
  director?: string;
  cast?: string;
  dateAdded?: string;
  releaseYear: number;
  rating: RatingType;
  duration?: string;
  listedIn?: string;
  description?: string;
}
