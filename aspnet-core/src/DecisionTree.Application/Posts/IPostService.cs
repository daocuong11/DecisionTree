using DecisionTree.Contracts.DTOs.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace DecisionTree.Posts
{
    public interface IPostService : ICrudAppService<PostDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePostDto>
    {
    }

    public class PostService : CrudAppService<Post, PostDto, Guid, PagedAndSortedResultRequestDto, CreateUpdatePostDto>, IPostService
    {
        public PostService(IRepository<Post, Guid> repository) : base(repository)
        {

        }
    }
}
