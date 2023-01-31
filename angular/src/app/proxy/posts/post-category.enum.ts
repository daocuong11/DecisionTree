import { mapEnumToOptions } from '@abp/ng.core';

export enum PostCategory {
  Post = 0,
  Blog = 1,
}

export const postCategoryOptions = mapEnumToOptions(PostCategory);
