using Microsoft.EntityFrameworkCore;

namespace ProductManagement.UnitofWork
{
    public interface IUnitofWork : IDisposable
    {
        DbContext Context { get; }
        public Task SaveChangesAsync();
    }
}
