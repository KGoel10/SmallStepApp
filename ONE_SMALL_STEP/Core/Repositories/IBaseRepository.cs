using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ONE_SMALL_STEP.Core.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class

    {
        //TEntity GetByID(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "");
        //TEntity Get2(string includeProperties);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProperties = "");

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate);
        //TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate, string includeProperties = "");


        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
        void Update(TEntity entity);

    }
}
