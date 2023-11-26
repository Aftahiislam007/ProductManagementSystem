using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models;
using ProductManagement.Repository;
using ProductManagement.UnitofWork;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        // GET: api/<CategoryController>
        private readonly IUnitofWork _unitofWork;
        IRepository<Category> categoryRepository;

        public CategoryController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            categoryRepository = new CategoryRepository(_unitofWork);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetCategories()
         { 
             var categories = await categoryRepository.Get();
             return categories;
         }

        [HttpPost]
        public async Task<ActionResult<Category>> CreateCategory(Category category)
        {
            var categories = await categoryRepository.Create(category);
            return categories;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            var categories = await categoryRepository.Delete(id);
            return categories;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, Category category)
        {
            var categories = await categoryRepository.Update(id, category);
            return categories;
        }
    }
}
