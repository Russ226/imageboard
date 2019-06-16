using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Models.ViewModels
{
    public class SubBoardViewModel
    {
        public List<PostModel> Posts { get; set; }
        public string BoardName { get; set; }
    }
}