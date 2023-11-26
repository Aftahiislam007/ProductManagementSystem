﻿using Microsoft.EntityFrameworkCore;
using ProductManagement.Data;

namespace ProductManagement.UnitofWork
{
    public class UnitofWork : IUnitofWork
    {
        private readonly AppDbContext _context;
        private bool _disposed = false;

        public UnitofWork(AppDbContext context)
        {
            _context = context;
        }
        public DbContext Context => _context;

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                _disposed = true;
            }
        }
    }
}