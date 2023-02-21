using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class
    {
        List<T> GetList(Expression<Func<T,bool>> filter=null);
        T GetByID(Expression<Func<T,bool>> filter);
        void Add(T t);
        void Remove(T t);
        void Update(T t);
    }
}
