using Microsoft.AspNetCore.Identity;
using SMARTECOMM.Infrastructure.Models;
using SMARTECOMM.Repository.Generics;
using SMARTECOMM.Repository.Interface;
using SMARTECOMM.Service.Interface;

namespace SMARTECOMM.Service.Services
{
    public class AccountService : BaseRepository<AccountModel>, IAccount
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        // private readonly IBaseRepository<AccountModel> _repository;
        //  private readonly IBaseRepository<AccountModel> _repository;
        // private readonly IBaseRepository<AccountModel> _repository;

        //public AccountService(IBaseRepository<AccountModel> repository)
        //{
        //    _repository = repository;
        //}

        public AccountService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AddNewAccount(AccountModel accountModel)
        {
            Save(accountModel);
        }
    }
}
