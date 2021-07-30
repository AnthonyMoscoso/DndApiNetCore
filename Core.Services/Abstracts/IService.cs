using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.Services.Abstracts
{
    public interface IService<T>
    {
        int Count();
        int Count(Expression<Func<T, bool>> expression);
        T GetSingle(int id);
        T GetSingle(Expression<Func<T, bool>> expression);
        IEnumerable<T> Get();
        IEnumerable<T> Get(Expression<Func<T, bool>> expression);
        IEnumerable<T> Get(Expression<Func<T, bool>> expression, string ordeer);
        IEnumerable<T> Get(Expression<Func<T, bool>> expression, string order, int pag, int element);
        IEnumerable<T> GetPaginate(string order, int pag, int elements);
        IEnumerable<T> GetOrderBy(string order);
        T Insert(T entity);
        IEnumerable<T> Insert (IEnumerable<T> list);
        T Update(T entity);
        IEnumerable<T> Update(IEnumerable<T> list);
        int Delete(int id);
        IEnumerable<int> Delete(IEnumerable<int> ids);
    }
}
