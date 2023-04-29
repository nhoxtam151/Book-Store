using Final_Exam_Project.Server.Services.ProductService;
using Final_Exam_Project.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Exam_Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        public IProductService ProductService { get; set; }

        public ProductController(IProductService product)
        {
            ProductService = product;
        }


        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            return Ok(await ProductService.LoadProducts());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> Get(int id)
        {
            return Ok(await ProductService.GetProductById(id));
        }

        [HttpGet("category/{id}")]
        public async Task<ActionResult<List<Product>>> GetProductByCategoryId(int id)
        {
            return Ok((await ProductService.LoadProducts()).Where(p => p.CategoryId == id).ToList());

        }
    }
}
