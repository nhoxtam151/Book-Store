using Final_Exam_Project.Server.Data;
using Final_Exam_Project.Shared;
using Microsoft.EntityFrameworkCore;

namespace Final_Exam_Project.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _DataContext;

        public ProductService(DataContext DataContext)
        {
            _DataContext = DataContext;
        }

        public async Task<List<Product>> LoadProducts()
        {
            return await _DataContext.Products.Include(p => p.Variants).ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _DataContext.Products.Include(p => p.Variants)
                .ThenInclude(v => v.Color).FirstOrDefaultAsync(product => product.Id == id);
        }

    }
}
