using SMARTECOMM.Repository.Interface;

namespace SMARTECOMM.Repository.Generics
{
    public class BaseReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly IUnitOfWork _unitOfWork;

        public BaseReadRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public T GetById(int id)
        {
            return _unitOfWork.Get<T>(id);
        }

        public T Get(T model)
        {
            return _unitOfWork.Get(model);
        }
    }
}
