using Final_Exam_Project.Shared;

namespace Final_Exam_Project.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<Category> GetCategoryByUrl(string url);
        Task<List<Category>> LoadCategory();

    }
}
