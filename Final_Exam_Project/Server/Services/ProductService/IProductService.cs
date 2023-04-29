using Final_Exam_Project.Shared;

namespace Final_Exam_Project.Server.Services.ProductService
{
    public interface IProductService
    {
        public Task<List<Product>> LoadProducts();

        public Task<Product> GetProductById(int id);

    }
}
