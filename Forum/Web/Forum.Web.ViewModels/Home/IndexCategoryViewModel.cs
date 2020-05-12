﻿using AutoMapper;
using Forum.Data.Models;
using Forum.Services.Mapping;

namespace Forum.Web.ViewModels.Home
{
    public class IndexCategoryViewModel : IMapFrom<Category>
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int PostsCount { get; set; }

        
        public string Url => $"/r/{this.Name.Replace(' ', '-')}";

        
    }
}