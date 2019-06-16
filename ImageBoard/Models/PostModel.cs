
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Link { get; set; }
        public int Likes { get; set; }
        public DateTime CreatedOn { get; set; }
        //public string CommentLink { get; set; }
    }
}