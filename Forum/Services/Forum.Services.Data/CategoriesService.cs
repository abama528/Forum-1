﻿using Forum.Data.Common.Repositories;
using Forum.Data.Models;
using Forum.Services.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Forum.Services.Data
{
    public class CategoriesService : ICategoriesService
    {
        private readonly IDeletableEntityRepository<Category> categoriesRepository;

        public CategoriesService(IDeletableEntityRepository<Category> categoriesRepository)
        {
            this.categoriesRepository = categoriesRepository;
        }
        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Category> query =
                this.categoriesRepository.All().OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);

            }
            return query.To<T>().ToList();
        }
    }
}
