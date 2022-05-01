using CV.Business.Interfaces;
using CV.DataAccess.Abstract;
using CV.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;


namespace CV.Business.Concrete
{
    public class GenericManager<TEntity> : IGenericService<TEntity> where TEntity:class,ITable,new()
    {
        private readonly IGenericRepository<TEntity> _genericService;

        public GenericManager(IGenericRepository<TEntity> genericService)
        {
            _genericService = genericService;
        }

        public void Delete(TEntity entity)
        {
            _genericService.Delete(entity);
        }

        public List<TEntity> GetAll()
        {
            return _genericService.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _genericService.GetById(id);
        }

        public void Insert(TEntity entity)
        {
            _genericService.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _genericService.Update(entity);
        }
    }
}
