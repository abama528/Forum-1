using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Forum.Data.Models;

namespace Forum.Data.Seeding
{
    public class CategorysSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Categories.Any())
            {
                return;
            }

            var categories = new List<string> { "Cartoons", "Anime", "Manga", "Video Games", "Mordekaiser",  };
            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category
                {
                    Name = category,
                    Description = category,
                    Title = category,
                });
            }
        }
    }
}
