using Final_Exam_Project.Shared;

namespace Final_Exam_Project.Client.Services.CategoryService
{
    public interface ICategoryServiceClient
    {
        public Task<List<Category>> GetCategories();

    }
}
