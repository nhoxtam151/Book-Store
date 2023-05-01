using Final_Exam_Project.Shared;
using System.Net.Http.Json;

namespace Final_Exam_Project.Client.Services.ProductService
{
    public class ProductServiceClient : IProductServiceClient
    {
        private readonly HttpClient _http;

        public ProductServiceClient(HttpClient http)
        {
            _http = http;
        }



        public async Task<Product> GetProductById(int id)
        {
            var product = await _http.GetFromJsonAsync<Product>($"api/product/{id}");
            return product;
        }

        public async Task<List<Product>> GetProducts()
        {
            var products = await _http.GetFromJsonAsync<List<Product>>("api/product");

            return products;
        }

        public async Task<List<Product>> GetProductsByCategoryId(int id)
        {
            var products = await _http.GetFromJsonAsync<List<Product>>($"api/product/category/{id}");
            return products;
        }
    }
}
