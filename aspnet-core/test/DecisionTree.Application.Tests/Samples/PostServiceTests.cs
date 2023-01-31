using DecisionTree.Contracts.DTOs.Post;
using DecisionTree.Posts;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Identity;
using Volo.Abp.Validation;
using Xunit;

namespace DecisionTree.Samples
{
    public class PostServiceTests : DecisionTreeApplicationTestBase
    {
        private readonly IPostService _postService;

        public PostServiceTests()
        {
            _postService = GetRequiredService<IPostService>();
        }

        [Fact]
        public async Task Add_New_Post_Should_Success()
        {
            // Arrange
            var post = new CreateUpdatePostDto()
            {
                Category = PostCategory.Post,
                Content = "Content",
                Title = "Title"
            };

            //Act
            var result = await _postService.CreateAsync(post);

            //Assert
            result.ShouldNotBeNull();
        }

        [Fact]
        public async Task Add_New_Post_Should_Show_Exception()
        {
            // Arrange
            var post = new CreateUpdatePostDto()
            {
                Category = PostCategory.Post,
                Content = "Content",
                Title = "The long-string instrument is a musical instrument in which the string is of such a length that the fundamental transverse wave is below what a person can hear as a tone (±20 Hz). If the tension and the length result in sounds with such a frequency, the tone becomes a beating frequency that ranges from a short reverb (approx 5–10 meters) to longer echo sounds (longer than 10 meters). Besides the beating frequency, the string also gives higher pitched natural overtones. Since the length is that long, this has an effect on the attack tone. The attack tone shoots through the string in a longitudinal wave and generates the typical science-fiction laser-gun sound as heard in Star Wars.[1] The sound is also similar to that occurring in upper electricity cables for trains (which are ready made long-string instruments in a way)."
            };

            //Act
            await Assert.ThrowsAsync<AbpValidationException>(() => _postService.CreateAsync(post));
        }
    }
}
