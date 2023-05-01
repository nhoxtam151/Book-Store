using Final_Exam_Project.Server.Services.CategoryService;
using Final_Exam_Project.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Final_Exam_Project.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService CategoryService)
        {
            categoryService = CategoryService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Category>>> GetAll()
        {
            return Ok(await categoryService.LoadCategory());
        }

        [HttpGet("{url}")]
        public async Task<ActionResult<Category>> GetCategoryByUrl(string url)
        {
            return Ok(await categoryService.GetCategoryByUrl(url));
        }
    }
}
