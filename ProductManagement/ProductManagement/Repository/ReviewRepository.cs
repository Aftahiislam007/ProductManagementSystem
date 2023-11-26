using ProductManagement.Models;
using ProductManagement.UnitofWork;

namespace ProductManagement.Repository
{
    public class ReviewRepository : RepositoryBase<Review>
    {
        public ReviewRepository(IUnitofWork unitofWork) : base(unitofWork)
        {
        }
    }
}
