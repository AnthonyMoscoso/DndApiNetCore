using Core.DataAccess.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Specifics.DataBases
{
    public abstract class EFBaseRepository<T> : IRepository<T>
        where T : class, new()
    {
        public DbContext _context;
        public DbSet<T> _table;
        public string _name;
        public string _identificator;
        public EFBaseRepository(DbContext context, string identificator)
        {
            _context = context;
            _table = _context.Set<T>();
            _identificator = identificator;
            _name = typeof(T).Name;
        }
        public int Count()
        {
            return _table.Count();
        }

        public int Count(Expression<Func<T, bool>> expression)
        {
            return _table.Count(expression);
        }

        public int Delete(int id)
        {
            T search = GetSingle(id);
            if (search != null)
            {
                _table.Remove(search);
                Save();
                return id;
            }
            else
            {
                throw new Exception($"{_name} with {_identificator}: {id} not was found ");
            }

        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void ExecuteQuery(string query)
        {
            _context.Database.ExecuteSqlRaw(query);
        }

        public IEnumerable<T> Get()
        {
            return _table;
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> expression)
        {
            return _table.Where(expression);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> expression, string order)
        {
            return _table.Where(expression).OrderBy(w => order);
        }

        public IEnumerable<T> Get(Expression<Func<T, bool>> expression, string order, int pag, int element)
        {
            return _table.Where(expression).OrderBy(w => order).Skip((pag - 1) * element).Take(element);
        }

        public IEnumerable<T> Get(string order, int pag, int elements)
        {
            return _table.OrderBy(w => order).Skip((pag - 1) * elements).Take(elements);
        }

        public IEnumerable<T> Get(string order)
        {
            return _table.OrderBy(w => order);
        }

        public T GetSingle(int id)
        {
            return _table.Find(id);
        }

        public T GetSingle(Expression<Func<T, bool>> expression)
        {
            return _table.SingleOrDefault(expression);
        }

        public T Insert(T entity)
        {
            _context.Add(entity);
            Save();
            return entity;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public dynamic Select(string query)
        {
            return _context.Database.ExecuteSqlRaw(query);
        }

        public T Update(T entity, int id)
        {
            T search = GetSingle(id);
            if (search != null)
            {
                _context.Update(entity);
                Save();
                return GetSingle(id);
            }
            else
            {
                throw new Exception($"{_name} with {_identificator}: {id} not was found");
            }
           
        }
    }
}
