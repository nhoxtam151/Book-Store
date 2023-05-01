using Final_Exam_Project.Server.Data;
using Final_Exam_Project.Shared;
using Microsoft.EntityFrameworkCore;

namespace Final_Exam_Project.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _context;

        public CategoryService(DataContext context)
        {
            _context = context;
        }

        public async Task<Category> GetCategoryByUrl(string url)
        {
            return await _context.Categories.FirstOrDefaultAsync(category => category.Url.ToLower().Equals(url.ToLower()));
        }

        public async Task<List<Category>> LoadCategory()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}
