import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';
import type { CreateUpdatePostDto, PostDto } from '../contracts/dtos/post/models';

@Injectable({
  providedIn: 'root',
})
export class PostService {
  apiName = 'Default';
  

  create = (input: CreateUpdatePostDto) =>
    this.restService.request<any, PostDto>({
      method: 'POST',
      url: '/api/app/post',
      body: input,
    },
    { apiName: this.apiName });
  

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/post/${id}`,
    },
    { apiName: this.apiName });
  

  get = (id: string) =>
    this.restService.request<any, PostDto>({
      method: 'GET',
      url: `/api/app/post/${id}`,
    },
    { apiName: this.apiName });
  

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<PostDto>>({
      method: 'GET',
      url: '/api/app/post',
      params: { sorting: input.sorting, skipCount: input.skipCount, maxResultCount: input.maxResultCount },
    },
    { apiName: this.apiName });
  

  update = (id: string, input: CreateUpdatePostDto) =>
    this.restService.request<any, PostDto>({
      method: 'PUT',
      url: `/api/app/post/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
