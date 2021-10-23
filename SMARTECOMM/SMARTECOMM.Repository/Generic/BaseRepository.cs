using SMARTECOMM.Repository.Interface;
using System.Collections.Generic;
using System.Linq;

namespace SMARTECOMM.Repository.Generics
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;
        public BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Save(T entity)
        {
            _unitOfWork.Save(entity);
        }

        public void Delete(T entityId)
        {
            _unitOfWork.Delete<T>(entityId);
        }

        public void Update(T entity)
        {
            _unitOfWork.Update(entity);
        }

        //public T Delete(int entityId)
        //{
        //  return  _unitOfWork.Delete(entityId);
        //}

        //public List<T> GetWithRawSqls<T>(string query, params object[] parameters) where T : class
        //{
        //    return _unitOfWork.GetWithRawSqls<T>(query, parameters).ToList();
        //}
    }
}
