using Final_Exam_Project.Shared;

namespace Final_Exam_Project.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<List<Category>> LoadCategory();

    }
}
