using Final_Exam_Project.Shared;

namespace Final_Exam_Project.Client.Services.ProductService
{
    public interface IProductServiceClient
    {


        public Task<List<Product>> GetProducts();

        public Task<Product> GetProductById(int id);

        public Task<List<Product>> GetProductsByCategoryId(int id);
    }
}
