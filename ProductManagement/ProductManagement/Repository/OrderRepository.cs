using ProductManagement.Models;
using ProductManagement.UnitofWork;

namespace ProductManagement.Repository
{
    public class OrderRepository : RepositoryBase<Order>
    {
        public OrderRepository(IUnitofWork unitofWork) : base(unitofWork)
        {
        }
    }
}
