using AutoMapper;
using ShopGame.Model.Models;
using ShopGame.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopGame.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Config()
        {
            Mapper.CreateMap<Post, PostViewModel>();
            Mapper.CreateMap<PostCateGory, PostCateGoryViewModel>();
            Mapper.CreateMap<Tag, TagViewModel>();
            Mapper.CreateMap<PostTag, PostTagViewModel>();
        }
        
     }
}