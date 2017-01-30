using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SQLite.Net;

namespace BitBrain.Core.Data.Interfaces
{
    public interface IRepository<T> where T : new()
    {
        TableQuery<T> AsQueryable();
        int Delete(T entity);
        T Get(int id);
        T Get(Expression<Func<T, bool>> predicate);
        List<T> Get<TValue>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TValue>> orderBy = null);
        int Insert(T entity);
        int InsertAll(List<T> entity);
        int Update(T entity);

    }
}
