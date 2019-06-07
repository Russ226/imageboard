using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Models
{
    public class RegisterModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}