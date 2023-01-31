using DecisionTree.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace DecisionTree.Contracts.DTOs.Post
{
    public class PostDto : EntityDto<Guid>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public PostCategory Category { get; set; }
    }
}
