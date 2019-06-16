using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageBoard.Data.Repository.Interfaces
{
    interface IPostRepo
    {
        IQueryable<PostModel> GetPostsByDate(string boardName);


    }
}
