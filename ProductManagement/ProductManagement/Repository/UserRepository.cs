using ProductManagement.Models;
using ProductManagement.UnitofWork;

namespace ProductManagement.Repository
{
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(IUnitofWork unitofWork) : base(unitofWork)
        {
        }
    }
}
