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

            var categories = new List<(string Name, string ImageUrl)>
            { 
                ("Cartoons", "https://i.ytimg.com/vi/YAbmqewtsp0/maxresdefault.jpg"),
                ("Anime","https://cdn.vox-cdn.com/thumbor/LJPYxcvOk7586_vc9wzfP_Y4Kj4=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/19661987/acastro_190807_3592_best_anime_2019_0001__1_.jpg"),
                ("Manga", "https://images-cdn.9gag.com/photo/a5RzENN_460s.jpg"),
                ("Video Games", "https://cdn.vox-cdn.com/thumbor/0VYNKoc-FH_kR7jphBE191cHGNw=/1400x1400/filters:format(jpeg)/cdn.vox-cdn.com/assets/3617075/2013-11-22_13-13-07.jpg"),
                ("Mordekaiser", "https://scontent-atl3-1.cdninstagram.com/v/t51.2885-15/sh0.08/e35/c0.105.1440.1440a/s640x640/91984739_316148032696715_1529371044452086582_n.jpg?_nc_ht=scontent-atl3-1.cdninstagram.com&_nc_cat=111&_nc_ohc=yXEypaEXLeoAX-lTh72&oh=fa5ba598ca7bf9dac4a2e47db2448838&oe=5EBC3500"), 
            };
            foreach (var category in categories)
            {
                await dbContext.Categories.AddAsync(new Category
                {
                    Name = category.Name,
                    Description = category.Name,
                    Title = category.Name,
                    ImageUrl = category.ImageUrl,
                });
            }
        }
    }
}
