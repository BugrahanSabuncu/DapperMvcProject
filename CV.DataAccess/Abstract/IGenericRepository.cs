using CV.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CV.DataAccess.Abstract
{
    public interface IGenericRepository<TEntity> where TEntity:class,ITable,new()
    {
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);
    }
}
