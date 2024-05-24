using ForumApi.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace ForumApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryManager _category;
        public CategoryController(CategoryManager category)
        {
            _category = category;
        }

        [HttpGet]
        public async Task<List<Models.Category>> GetAync()
        {
            var category = await _category.GetCategories();
            return category;
        }
    }
}
