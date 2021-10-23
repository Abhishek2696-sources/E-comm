using SMARTECOMM.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMARTECOMM.Service.Interface
{
    public interface IAccount
    {
        void AddNewAccount(AccountModel accountModel);
    }
}
