using ImageBoard.Data.Repository.Interfaces;
using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ImageBoard.Helpers.Exceptions;

namespace ImageBoard.Data.Repository
{
    public class AccountRepo : IAccountRepo
    {
        private imageboardEntities _db;

        public AccountRepo() {
            _db = new imageboardEntities();
        }

        #region private methods

        private bool DoesUserExist(string username, string email) {
            var checkUsername = _db.users.Where(x => x.username == username).FirstOrDefault();
            var checkEmail = _db.users.Where(x => x.username == username).FirstOrDefault();

            return checkEmail != null || checkUsername != null? false : true;
        }

        #endregion

        public void RegisterUser(RegisterModel user) {
            if (DoesUserExist(user.Username, user.Email)) throw new UserExistsException();

            var newUserAdd = new user
            {
                username = user.Username,
                email = user.Email,
                password = user.Password,
                created_on = DateTime.Now
            };

            _db.users.Add(newUserAdd);
            _db.SaveChanges();
        }


    }
}