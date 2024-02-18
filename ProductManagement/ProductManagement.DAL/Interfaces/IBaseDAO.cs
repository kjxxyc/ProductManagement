using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement.DAL.Interfaces
{
    public interface IBaseDAO <TEntity> where TEntity : class
    {

        /// <summary>
        /// Get all entities records.
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();


        /// <summary>
        /// Get all entities filtered by the specified predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        IEnumerable<TEntity> GetListWithFilter(Expression<Func<TEntity, bool>> predicate);


        /// <summary>
        /// Get a entity filtered by the specified predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        TEntity GetSingleWithFilter(Expression<Func<TEntity, bool>> predicate);


        /// <summary>
        /// Get entity by its Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TEntity FindById(int id);



        /// <summary>
        /// Check if an entity meets the specified predicate.
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        bool CheckWithCondition(Expression<Func<TEntity, bool>> predicate, string includeProperties = null);


        /// <summary>
        /// Create a new record.
        /// </summary>
        /// <param name="entity">Entity to create</param>
        int Create(TEntity entity);


        /// <summary>
        /// Update an entity.
        /// </summary>
        /// <param name="entity">Entity to update.</param>
        int Update(TEntity entity);


        /// <summary>
        /// Delete an entity.
        /// </summary>
        /// <param name="entity">Entity to delete.</param>
        int Delete(TEntity entity);


        /// <summary>
        /// Reload record.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        TEntity Reload(TEntity entity);
    }
}
