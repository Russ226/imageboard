using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Controllers.Account
{
    public class UserCookie
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        public UserCookie(UserModel user) {
            Id = user.Id;
            Username = user.Username;
            Email = user.Email;
        }
    }
}