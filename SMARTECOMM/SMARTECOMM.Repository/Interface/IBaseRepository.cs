using System.Collections.Generic;
using System.Threading;

namespace SMARTECOMM.Repository.Interface
{
    public interface IBaseRepository<T> where T : class
    {
        void Update<T>(T entityToUpdate) where T : class;
        void Save<T>(T model) where T : class;
        void Delete<T>(T id) where T : class;
        T Get<T>(int id) where T : class;
        T Get<T>(T model) where T : class; //added
        IEnumerable<T> GetWithRawSqls<T>(string query, params object[] parameters) where T : class;
        //T Delete<T>(T entity);
        //void Save<T>(T entity);
        void AddRangeAsync<T>(IEnumerable<T> entities) where T : class;

        void AddRangeAsync<T>(IEnumerable<T> entities, CancellationToken cancellationToken = default) where T : class;
        IEnumerable<T> GetAll<T>() where T : class;
        void RemoveRange<T>(IEnumerable<T> entities) where T : class;
    }
}
