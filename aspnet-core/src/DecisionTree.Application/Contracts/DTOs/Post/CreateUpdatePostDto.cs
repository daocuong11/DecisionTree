using DecisionTree.Posts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionTree.Contracts.DTOs.Post
{
    public class CreateUpdatePostDto
    {
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public PostCategory Category { get; set; }
    }
}
