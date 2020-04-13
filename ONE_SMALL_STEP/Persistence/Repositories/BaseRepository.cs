using ONE_SMALL_STEP.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace ONE_SMALL_STEP.Persistence.Repositories
{
    public class Repository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        internal DbSet<TEntity> dbSet;
        protected readonly DbContext Context;

        //public Repository(DbContext context)
        //{
        //    Context = context;
        //}


        public Repository(DbContext context)
        {
            this.Context = context;
            this.dbSet = context.Set<TEntity>();
        }



        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().AddRange(entities);
        }

        public void Update(TEntity entity)
        {
            //throw new NotImplementedException();
            Context.Entry(entity).State = EntityState.Modified;
            //Context.Set<TEntity>().Attach(entity);
            //Context.Set<TEntity>().
            //Context.Set<TEntity>().(entity);
            //Context.Set<TEntity>().en Entry. (entity).State = EntityState.Modified;

        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().Where(predicate);
        }

        ////public TEntity GetByID(int id, string includeProperties = "")
        //public TEntity GetByID(Expression<Func<TEntity, bool>> filter = null, string includeProperties = "")
        //{
        //    // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
        //    // such as Courses or Authors, and we need to use the generic Set() method to access them.

        //    IQueryable<TEntity> query = dbSet;

        //    if (filter != null)
        //    {
        //        query = query.Where(filter);
        //    }

        //    //foreach (var includeProperty in includeProperties.Split
        //    //    (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
        //    //{
        //    //    query = query.Include(includeProperty);
        //    //}

        //    // return query.Where(x=>x.)
        //    //return Context.Set<TEntity>().Find(id);
        //    // return Context.Set<TEntity>().Find(id);
        //    return query.FirstOrDefault();
        //    //p => p.PersonID == id

        //}

        public IEnumerable<TEntity> GetAll()
        {
            // Note that here I've repeated Context.Set<TEntity>() in every method and this is causing
            // too much noise. I could get a reference to the DbSet returned from this method in the 
            // constructor and store it in a private field like _entities. This way, the implementation
            // of our methods would be cleaner:
            // 
            // _entities.ToList();
            // _entities.Where();
            // _entities.SingleOrDefault();
            // 
            List<TEntity> tlist= Context.Set<TEntity>().ToList();

            // I didn't change it because I wanted the code to look like the videos. But feel free to change
            // this on your own.
            return Context.Set<TEntity>().ToList();
        }


        public virtual IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "")
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties.Split
                (new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            else
            {
                return query.ToList();
            }
        }
        public void Remove(TEntity entity)
        {
            Context.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            Context.Set<TEntity>().RemoveRange(entities);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().SingleOrDefault(predicate);
        }

        //public void Update(TEntity entity)
        //{
        //    throw new NotImplementedException();
        //}

       
    }
}