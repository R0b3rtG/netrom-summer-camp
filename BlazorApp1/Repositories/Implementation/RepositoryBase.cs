﻿using Microsoft.EntityFrameworkCore;
using BlazorApp1.Context;
using BlazorApp1.Repositories.Interfaces;

namespace BlazorApp1.Repositories.Implementation
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly ShowTimeContext _context;
        private readonly DbSet<T> _dbSet;

        public RepositoryBase(ShowTimeContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<T?> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
