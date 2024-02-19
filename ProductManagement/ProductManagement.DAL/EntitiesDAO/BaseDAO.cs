using ProductManagement.DAL.Interfaces;
using ProductManagement.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DAL.EntitiesDAO
{
    public class BaseDAO<TEntity> : IBaseDAO<TEntity> where TEntity : class
    {
        // Definition of the field for context.
        public readonly ModelProductManagementDbContext _context;
        
        public BaseDAO()
        {
            _context = new ModelProductManagementDbContext();
            
        }

        /// <summary>
        /// Create a new record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(TEntity entity, bool saveChanges = true)
        {
            var affectedRows = 0;
            _context.Set<TEntity>().Add(entity);

            if (saveChanges)
            {
                affectedRows = _context.SaveChanges();  
            }

            return affectedRows;
        }


        /// <summary>
        /// Update an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(TEntity entity, bool saveChanges = true)
        {
            var affectedRows = 0;

            _context.Entry<TEntity>(entity).State = EntityState.Modified;

            if (saveChanges)
            {
                affectedRows = _context.SaveChanges();
            }

            return affectedRows;
        }

        /// <summary>
        /// Delete an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(TEntity entity, bool saveChanges = true)
        {
            var affectedRows = 0;

            _context.Set<TEntity>().Remove(entity);

            if (saveChanges)
            {
                affectedRows = _context.SaveChanges();
            }

            return affectedRows;
        }


        /// <summary>
        /// Get entity by its id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public TEntity FindById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        /// <summary>
        /// Get all entities records.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().AsNoTracking().ToList();
        }


        /// <summary>
        /// Get all entities filtered by the specified predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetListWithFilter(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).AsNoTracking().ToList();
        }

        /// <summary>
        /// Get a entity filtered by the specified predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TEntity GetSingleWithFilter(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().AsNoTracking().FirstOrDefault(predicate);
        }

        /// <summary>
        /// Reload record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public TEntity Reload(TEntity entity)
        {
            _context.Entry(entity).Reload();

            return entity;
        }

        /// <summary>
        /// Check if an entity meets the specified predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        public bool CheckWithCondition(Expression<Func<TEntity, bool>> predicate, string includeProperties = null)
        {
            var query = _context.Set<TEntity>().AsNoTracking().AsQueryable();

            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var prop in includeProperties.Split(','))
                {
                    query = query.Include(prop);
                }
            }

            return query.Any(predicate);
        }
    }
}
