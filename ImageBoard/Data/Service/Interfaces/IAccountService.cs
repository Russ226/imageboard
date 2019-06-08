using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageBoard.Data.Service.Interfaces
{
    public interface IAccountService
    {
        void RegisterUser(RegisterModel user);
    }
}
