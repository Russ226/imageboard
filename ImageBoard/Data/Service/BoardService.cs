using ImageBoard.Data.Repository.Interfaces;
using ImageBoard.Data.Service.Interfaces;
using ImageBoard.Helpers.Exceptions;
using ImageBoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// all boards will have a welcome post automacially so if a post query is empty then board doesnt exist
/// </summary>
namespace ImageBoard.Data.Service
{
    public class BoardService: IBoardService 
    {
        private IPostRepo _postRepo;

        public BoardService(IPostRepo postRepo) {
            _postRepo = postRepo;
        }

        public List<PostModel> GetRecentPost(string board, int page = 0)
        {
            int pageSize = 10;

            var posts = _postRepo.GetPostsByDate(board);
            if (!posts.Any()) {
                throw new BoardExistsException();
            }
            posts = posts.Skip(page * pageSize).Take(pageSize);

            return posts.ToList();
        }
    }
}