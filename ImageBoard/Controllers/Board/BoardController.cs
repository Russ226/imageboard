using ImageBoard.Data.Service.Interfaces;
using ImageBoard.Helpers.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ImageBoard.Controllers.Board
{
    public class BoardController : Controller
    {
        private IBoardService _boardService;

        public BoardController(IBoardService boardService)
        {
            _boardService = boardService;
        }



        // GET: Board
        public ActionResult Index()
        {
            return View();
        }

        
        [Route("Image/Board/{boardName}")]
        public ActionResult Board(string boardName, int page = 0) {
            try
            {
                var posts = _boardService.GetRecentPost(boardName, page);
                var subBoard = new Models.ViewModels.SubBoardViewModel
                {
                    Posts = posts,
                    BoardName = boardName

                };
                return View("SubBoardPage", subBoard);
            }
            catch (BoardExistsException ex) {
                Trace.Write(ex.Message);
                return View("Error");
            }

            
        }
    }
}