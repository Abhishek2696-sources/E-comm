using System.Collections.Generic;

namespace SMARTECOMM.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        void Save(T entity);
        void Delete(T entityId);
        // T Delete(int entityId);
        void Update(T entity);
       // List<T> GetWithRawSqls<T>(string query, params object[] parameters) where T : class;
    }
}
