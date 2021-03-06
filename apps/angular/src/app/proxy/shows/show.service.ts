import type { CreateUpdateShowDto, ShowDto } from './models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class ShowService {
  apiName = 'Default';

  create = (input: CreateUpdateShowDto) =>
    this.restService.request<any, ShowDto>({
      method: 'POST',
      url: `/api/app/show`,
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: number) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/show/${id}`,
    },
    { apiName: this.apiName });

  get = (id: number) =>
    this.restService.request<any, ShowDto>({
      method: 'GET',
      url: `/api/app/show/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<ShowDto>>({
      method: 'GET',
      url: `/api/app/show`,
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: number, input: CreateUpdateShowDto) =>
    this.restService.request<any, ShowDto>({
      method: 'PUT',
      url: `/api/app/show/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
