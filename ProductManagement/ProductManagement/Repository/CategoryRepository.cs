using ProductManagement.Models;
using ProductManagement.UnitofWork;

namespace ProductManagement.Repository
{
    public class CategoryRepository : RepositoryBase<Category>
    {
        public CategoryRepository(IUnitofWork unitofWork) : base(unitofWork)
        {
        }
    }
}
