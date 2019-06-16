using ImageBoard.Data.Repository.Interfaces;
using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Data.Repository
{
    public class PostRepo : IPostRepo
    {
        private imageboardEntities _db;

        public PostRepo()
        {
            _db = new imageboardEntities();
        }

        public IQueryable<PostModel> GetPostsByDate(string boardName)
        {
            var query = from board in _db.subboardpostjoins
                        where board.subBoardName == boardName
                        join postQ in _db.posts
                        on board.post_id equals postQ.id
                        orderby postQ.created_on
                        select new PostModel
                        {
                            Id = postQ.id,
                            Username = postQ.username,
                            Title = postQ.title,
                            Link = postQ.link,
                            CreatedOn = postQ.created_on,
                            //should change this up later 
                            //Likes = postQ.postlikes.Where(x => x.post_id == postQ.id).Sum(y => int.Parse(y.liked.ToString()))
                        };

            return query;

        }
    }
}