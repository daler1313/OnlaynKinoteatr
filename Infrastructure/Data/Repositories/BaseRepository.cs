﻿using Domain.Entities;
using Domain.Interfaces.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public async Task<TEntity> CreateAsync(TEntity entity, CancellationToken token = default)
        {
            await _dbSet.AddAsync(entity, token);
            await _context.SaveChangesAsync(token);
            return entity;
        }

        public async Task<bool> DeleteAsync(TEntity entity, CancellationToken token = default)
        {
            _dbSet.Remove(entity);
            return await _context.SaveChangesAsync(token) > 0;
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(CancellationToken token = default)
        {
            return await _dbSet.ToListAsync(token);
        }

        public async Task<TEntity> GetAsync(int id, CancellationToken token = default)
        {
            return await _dbSet.FindAsync(id, token);
        }

        public Task<T> GetAsync<T>(int id, CancellationToken token)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(TEntity entity, CancellationToken token = default)
        {
            _dbSet.Update(entity);
            return await _context.SaveChangesAsync(token) > 0;
        }

    }
}
