using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models;
using ProductManagement.Repository;
using ProductManagement.UnitofWork;

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitofWork _unitofWork;
        IRepository<Product> productRepository;

        public ProductController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            productRepository = new ProductRepository(_unitofWork);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            var products = await productRepository.Get();
            return products;
        }

        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            var products = await productRepository.Create(product);
            return products;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var products = await productRepository.Delete(id);
            return products;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, Product product)
        {
            var products = await productRepository.Update(id, product);
            return products;
        }
    }
}
