using ProductManagement.Models;
using ProductManagement.UnitofWork;

namespace ProductManagement.Repository
{
    public class ProductRepository : RepositoryBase<Product>
    {
        public ProductRepository(IUnitofWork unitofWork) : base(unitofWork)
        {
        }
    }
}
