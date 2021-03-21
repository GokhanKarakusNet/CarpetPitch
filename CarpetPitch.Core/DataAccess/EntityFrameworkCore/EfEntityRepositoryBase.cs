using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarpetPitch.Core.DataAccess.EntityFrameworkCore
{
    //public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
    //    where TEntity : class, IEntity, new()
    //    where TContext : DbContext, new()
    //{
    //        public TEntity Add(TEntity entity)
    //        {
    //            using var context = new TContext();
    //            var addedEntity = context.Entry(entity);
    //            addedEntity.State = EntityState.Added;
    //            context.SaveChanges();
    //            return entity;
    //        }

    //        public async Task<TEntity> AddAsync(TEntity entity)
    //        {
    //            await using var context = new TContext();
    //            var addedEntity = context.Entry(entity);
    //            addedEntity.State = EntityState.Added;
    //            await context.SaveChangesAsync();
    //            return entity;
    //        }



    //        public void Delete(TEntity entity)
    //        {
    //            using var context = new TContext();
    //            var deletedEntity = context.Entry(entity);
    //            deletedEntity.State = EntityState.Deleted;
    //            context.SaveChanges();
    //        }

    //        public async Task DeleteAsync(TEntity entity)
    //        {
    //            await using var context = new TContext();
    //            var deletedEntity = context.Entry(entity);
    //            deletedEntity.State = EntityState.Deleted;
    //            await context.SaveChangesAsync();
    //        }

    //        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
    //        {
    //            using var context = new TContext();
    //            return context.Set<TEntity>().SingleOrDefault(filter);
    //        }

    //        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
    //        {
    //            using var context = new TContext();
    //            return filter == null
    //                ? context.Set<TEntity>().ToList()
    //                : context.Set<TEntity>().Where(filter).ToList();
    //        }

    //        public TEntity Update(TEntity entity)
    //        {
    //            using var context = new TContext();
    //            var updatedEntity = context.Entry(entity);
    //            updatedEntity.State = EntityState.Modified;
    //            context.SaveChanges();
    //            return entity;
    //        }

    //        public async Task<TEntity> UpdateAsync(TEntity entity)
    //        {
    //            await using var context = new TContext();
    //            var updatedEntity = context.Entry(entity);
    //            updatedEntity.State = EntityState.Modified;
    //            await context.SaveChangesAsync();
    //            return entity;
    //        }
    //    }
    //}

    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
                return entity;
            }
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                await context.SaveChangesAsync();
                return entity;
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public async Task DeleteAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                await context.SaveChangesAsync();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public TEntity Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
                return entity;
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            using (var context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                await context.SaveChangesAsync();
                return entity;
            }
        }
    }
}
