using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ToDoList.Core.Entites.Abstract;

namespace ToDoList.Core.Business.Abstract
{
   public interface IGenericService<T> where T:class,IEntity,new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
