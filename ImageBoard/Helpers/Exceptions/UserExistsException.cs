using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Helpers.Exceptions
{
    public class UserExistsException : Exception
    {
       
        public UserExistsException() : base("Username or Email is taken by another user")
        { }
    }
}