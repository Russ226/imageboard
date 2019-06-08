using ImageBoard.Data.Repository.Interfaces;
using ImageBoard.Data.Service.Interfaces;
using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Data.Service
{
    public class AccountService : IAccountService
    {
        private IAccountRepo _accountRepo;

        public AccountService(IAccountRepo accountRepo) {
            _accountRepo = accountRepo;
        }

        public void RegisterUser(RegisterModel user)
        {
            _accountRepo.RegisterUser(user);
        }
    }
}