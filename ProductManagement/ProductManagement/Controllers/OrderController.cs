using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Models;
using ProductManagement.Repository;
using ProductManagement.UnitofWork;

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IUnitofWork _unitofWork;
        IRepository<Order> orderRepository;

        public OrderController(IUnitofWork unitofWork)
        {
            _unitofWork = unitofWork;
            orderRepository = new OrderRepository(_unitofWork);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrders()
        {
            var orders = await orderRepository.Get();
            return orders;
        }

        [HttpPost]
        public async Task<ActionResult<Order>> CreateOrder(Order order)
        {
            var orders = await orderRepository.Create(order);
            return orders;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var orders = await orderRepository.Delete(id);
            return orders;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateOrder(int id, Order order)
        {
            var orders = await orderRepository.Update(id, order);
            return orders;
        }
    }
}
