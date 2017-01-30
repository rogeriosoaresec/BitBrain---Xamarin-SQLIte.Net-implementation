using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BitBrain.Core.Data.Abstract;
using BitBrain.Core.Data.Interfaces;
using SQLite.Net;
using SQLiteNetExtensions.Extensions;

namespace BitBrain.Core.Data.Repository
{
    public class Repository<T> : IDisposable, IRepository<T> where T : class, new()
    {
        public DatabaseContext db;

        public Repository(DatabaseContext db)
        {
            this.db = db;
        }
        public TableQuery<T> AsQueryable()
        {
            return db.Database.Table<T>();
        }

        public int Delete(T entity)
        {
            return db.Database.Delete(entity);
        }

        public T Get(int id)
        {
            return db.Database.Find<T>(id);
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {
            return db.Database.Find<T>(predicate);
        }

        public List<T> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null)
        {

            var query = db.Database.Table<T>();

            if (predicate != null)
                query = query.Where(predicate);

            if (orderBy != null)
                query = query.OrderBy<TValue>(orderBy);

            return query.ToList();
        }

        public int Insert(T entity)
        {
            return db.Database.Insert(entity);
        }

        public int InsertAll(List<T> entity)
        {
            return db.Database.InsertAll(entity);
        }

        public int Update(T entity)
        {
            return db.Database.Update(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
