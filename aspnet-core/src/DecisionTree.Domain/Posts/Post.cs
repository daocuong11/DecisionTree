using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace DecisionTree.Posts
{
    public class Post : AggregateRoot<Guid>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public PostCategory Category { get; set; }
    }
}
