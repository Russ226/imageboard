using ImageBoard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }

        public UserModel(user user) {
            Id = user.id;
            Email = user.email;
            Username = user.username;
        }
    }
}