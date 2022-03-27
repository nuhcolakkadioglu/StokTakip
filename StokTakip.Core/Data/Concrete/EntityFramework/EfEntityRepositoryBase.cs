﻿using Microsoft.EntityFrameworkCore;
using StokTakip.Core.Data.Abstract;
using StokTakip.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StokTakip.Core.Data.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity> : IEntityRepository<TEntity> where TEntity : class, IEntity, new()
    {
        private readonly DbContext _context;
        public EfEntityRepositoryBase(DbContext dbContext)
        {
            _context = dbContext;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            return entity;
        }

        public async Task<bool> AnyAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().AnyAsync(expression);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> expression)
        {
            return await _context.Set<TEntity>().CountAsync(expression);
        }


        public async Task<IList<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> expression = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (expression is not null)
            {
                query = query.Where(expression);
            }

            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> expression, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = _context.Set<TEntity>();
            if (expression is not null)
            {
                query = query.Where(expression);
            }

            if (includeProperties.Any())
            {
                foreach (var item in includeProperties)
                {
                    query = query.Include(item);
                }
            }

            return await query.SingleOrDefaultAsync();
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            await Task.Run(() =>
            {
                _context.Set<TEntity>().Update(entity);
            });

            return entity;
        }
        public async Task DeleteAsync(TEntity entity)
        {
            await Task.Run(() => { _context.Set<TEntity>().Remove(entity)});

        }
    }
}
