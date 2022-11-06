using AutoMapper;
using SunSun.Model.Models;
using SunSun.Web.Models;

namespace SunSun.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Post, PostViewModel>();
                cfg.CreateMap<PostCategory, PostCategoryViewModel>();
                cfg.CreateMap<Tag, TagViewModel>();
                cfg.CreateMap<PostTag, PostTagViewModel>();
            });
        }
    }
}