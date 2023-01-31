using AutoMapper;
using DecisionTree.Contracts.DTOs.Post;
using DecisionTree.Posts;

namespace DecisionTree;

public class DecisionTreeApplicationAutoMapperProfile : Profile
{
    public DecisionTreeApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */

        CreateMap<Post, PostDto>();
        CreateMap<CreateUpdatePostDto, Post>();
    }
}
