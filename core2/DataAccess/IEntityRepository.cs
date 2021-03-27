
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    // Burada class referans tip demektir.
    // IEntity : IEntity olabilir veya IEntity implemt eden bir nesne olabilir demektir.
    // new() : new'lenebilir olmalı demektir. Yani IEntity'yi (kelime olarak) yazmamak için yaptık. 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

       
    }
}
