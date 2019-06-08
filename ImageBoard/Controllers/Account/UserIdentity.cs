using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace ImageBoard.Controllers.Account
{
    public class UserIdentity : IIdentity
    {
        public IIdentity Identity { get; set; }
        public UserCookie User {get; set;}
        public string AuthenticationType
        {
            get { return Identity.AuthenticationType; }
        }

        public bool IsAuthenticated {
            get { return Identity.IsAuthenticated; }
        }

        public string Name {
            get { return Identity.Name; }
        }

        public UserIdentity(UserCookie user) {
            Identity = new GenericIdentity(User.Id.ToString());
            User = user;
        }



        
    }
}