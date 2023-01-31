import type { PostCategory } from '../../../posts/post-category.enum';
import type { EntityDto } from '@abp/ng.core';

export interface CreateUpdatePostDto {
  title: string;
  content: string;
  category: PostCategory;
}

export interface PostDto extends EntityDto<string> {
  title?: string;
  content?: string;
  category: PostCategory;
}
