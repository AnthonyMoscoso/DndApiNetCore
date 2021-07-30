using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstracts
{
    public interface IRepository<T>
    {
        int Count();
        int Count(Expression<Func<T, bool>> expression);
        T GetSingle(int id);
        T GetSingle(Expression<Func<T, bool>> expression);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
        IEnumerable<T> Get(Expression<Func<T, bool>> expression, string ordeer);
        IEnumerable<T> Get(Expression<Func<T, bool>> expression, string order, int pag, int element);
        IEnumerable<T> Get(string order, int pag, int elements);
        IEnumerable<T> Get(string order);
        T Insert(T entity);
        T Update(T entity, int id);
        int Delete(int id);
        void Save();
        void Dispose();
        void ExecuteQuery(string query);
        dynamic Select(string query);
    }
}
