using AutoMapper;
using Businness.Mapper.Automapper;
using Core.DataAccess.Abstracts;
using Core.DataAccess.Specifics;
using Core.Models.Abstracts;
using Core.Services.Abstracts;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.Services.Specifics.Mapper
{
    public abstract class MapperBaseService<TDto, T> : IService<TDto>
        where TDto : class, IEntity, new()
    {
        string _Name { get; set; }
        public IRepository<T> _repository;
        public IMapper _mapper;
        public IValidator<TDto> _Validator;
        public ValidationResult _validatorResult;
        public MapperBaseService(IRepository<T> repository,IMapper mapper, IValidator<TDto> validator)
        {
            _repository = repository;
            _Name = typeof(T).Name;
            _Validator = validator;
            _mapper = mapper;
        }

        public int Count()
        {
            return _repository.Count();
        }

        public int Count(Expression<Func<TDto, bool>> expression)
        {
            Expression<Func<T, bool>> filter = _mapper.Map<Expression<Func<T, bool>>>(expression);
            return _repository.Count(filter);
        }

        public TDto GetSingle(int id)
        {
            T result = _repository.GetSingle(id);
            return _mapper.Map<TDto>(result);
        }

        public TDto GetSingle(Expression<Func<TDto, bool>> expression)
        {
            Expression<Func<T, bool>> filter = _mapper.Map<Expression<Func<T, bool>>>(expression);
            T result = _repository.GetSingle(filter);
            return _mapper.Map<TDto>(result);
        }

        public IEnumerable<TDto> Get()
        {
            IEnumerable<T> result = _repository.Get();
            return _mapper.Map<IEnumerable<TDto>>(result);
        }

        public IEnumerable<TDto> Get(Expression<Func<TDto, bool>> expression)
        {
            Expression<Func<T, bool>> filter = _mapper.Map<Expression<Func<T, bool>>>(expression);
            IEnumerable<T> result = _repository.Get(filter);
            return _mapper.Map<IEnumerable<TDto>>(result);
        }

        public IEnumerable<TDto> Get(Expression<Func<TDto, bool>> expression, string order)
        {
            Expression<Func<T, bool>> filter = _mapper.Map<Expression<Func<T, bool>>>(expression);
            IEnumerable<T> result = _repository.Get(filter, order);
            return _mapper.Map<IEnumerable<TDto>>(result);
        }

        public IEnumerable<TDto> Get(Expression<Func<TDto, bool>> expression, string order, int pag, int element)
        {
            Expression<Func<T, bool>> filter = _mapper.Map<Expression<Func<T, bool>>>(expression);
            IEnumerable<T> result = _repository.Get(filter, order, pag, element);
            return _mapper.Map<IEnumerable<TDto>>(result);
        }

        public IEnumerable<TDto> GetPaginate(string order, int pag, int elements)
        {
            IEnumerable<T> result = _repository.Get(order, pag, elements);
            return _mapper.Map<IEnumerable<TDto>>(result);
        }

        public IEnumerable<TDto> GetOrderBy(string order)
        {
            IEnumerable<T> result = _repository.Get(order);
            return _mapper.Map<IEnumerable<TDto>>(result);
        }

        public TDto Insert(TDto entity)
        {
            _validatorResult = _Validator.Validate(entity);
            if (_validatorResult.IsValid)
            {
                T search = _mapper.Map<T>(_repository.GetSingle(entity._Id));
                if (search != null)
                {
                    T e = _mapper.Map<T>(entity);
                    return _mapper.Map<TDto>(_repository.Insert(e));
                }
                else
                {
                    throw new Exception($"{_Name} with id :{entity._Id} not was found");
                }
            }
            else
            {

                throw new Exception($"{_validatorResult.Errors.FirstOrDefault().ErrorCode}: {_validatorResult.Errors.First().ErrorMessage}");
            }
  
        }

        public IEnumerable<TDto> Insert(IEnumerable<TDto> list)
        {
            foreach (TDto dto in list)
            {
                yield return Insert(dto);
            }

        }

        public TDto Update(TDto entity)
        {
            _validatorResult = _Validator.Validate(entity);
            if (_validatorResult.IsValid)
            {
                T e = _mapper.Map<T>(_repository.GetSingle(entity._Id));
                if (e != null)
                {
                    e = _mapper.Map<T>(entity);
                    return _mapper.Map<TDto>(_repository.Update(e, entity._Id));
                }
                else
                {
                    throw new Exception($"{_Name} with id:{entity._Id} not was found");
                }
            }
            else
            {
                throw new Exception($"{_validatorResult.Errors.FirstOrDefault().ErrorCode}: {_validatorResult.Errors.First().ErrorMessage}");
            }
      

        }

        public IEnumerable<TDto> Update(IEnumerable<TDto> list)
        {
            foreach (TDto dto in list)
            {
                yield return Update(dto);
            }
        }

        public int Delete(int id)
        {
            T search = _repository.GetSingle(id);
            if (search != null)
            {
                return _repository.Delete(id);
            }
            else
            {
                throw new Exception($"{_Name} with id:{id} not was found");
            }
        }

        public IEnumerable<int> Delete(IEnumerable<int> ids)
        {
            foreach (int id in ids)
            {
                yield return Delete(id);
            }
        }
    }
}
