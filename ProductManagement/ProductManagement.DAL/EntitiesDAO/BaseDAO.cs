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
        private readonly ModelProductManagementDbContext _context;
        
        public BaseDAO()
        {
            _context = new ModelProductManagementDbContext();
        }

        /// <summary>
        /// Create a new record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            return _context.SaveChanges();
        }


        /// <summary>
        /// Update an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Update(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;

            return _context.SaveChanges();
        }

        /// <summary>
        /// Delete an entity.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public int Delete(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);

            return _context.SaveChanges();
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
            return _context.Set<TEntity>().ToList();
        }


        /// <summary>
        /// Get all entities filtered by the specified predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public IEnumerable<TEntity> GetListWithFilter(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().Where(predicate).ToList();
        }

        /// <summary>
        /// Get a entity filtered by the specified predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public TEntity GetSingleWithFilter(Expression<Func<TEntity, bool>> predicate)
        {
            return _context.Set<TEntity>().FirstOrDefault(predicate);
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
            var query = _context.Set<TEntity>().AsQueryable();

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
