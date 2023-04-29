using Final_Exam_Project.Shared;

namespace Final_Exam_Project.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        public List<Category> Categories { get; set; } = new List<Category>
            {
                new Category
                {
                    Id = 1,
                    Name="Books",
                    Url = "books",
                    Icon = "book"
                },
                new Category
                {
                    Id = 2,
                    Name = "Eletronics",
                    Url = "electronics",
                    Icon = "camera-slr"
                },
                new Category {
                    Id = 3,
                    Name = "Video games",
                    Url = "video-games",
                    Icon = "aperture"
                }
            };

        public async Task<List<Category>> LoadCategory()
        {
            return Categories;
        }
    }
}
