using Final_Exam_Project.Shared;
using System.Net.Http.Json;

namespace Final_Exam_Project.Client.Services.CategoryService
{
    public class CategoryServiceClient : ICategoryServiceClient
    {
        private readonly HttpClient _http;

        public CategoryServiceClient(HttpClient http)
        {
            _http = http;
        }



        public async Task<List<Category>> GetCategories()
        {
            var categories = await _http.GetFromJsonAsync<List<Category>>("api/category");

            return categories;

        }

        public async Task<Category> GetCategoryByUrl(string url)
        {
            var category = await _http.GetFromJsonAsync<Category>($"api/category/{url}");
            return category;
        }
    }
}
