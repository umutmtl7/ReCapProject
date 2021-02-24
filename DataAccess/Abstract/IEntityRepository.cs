using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //Adding Generic Repository Design Pattern
    //class ---> can be reference type
    //IEntity ---> can be IEntity or an object implementing it,    new() ----> Can't IEntity itself because cannot be use new.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //delegation
        List<T> GetAll(Expression<Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
