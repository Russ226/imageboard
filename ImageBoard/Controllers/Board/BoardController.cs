using ImageBoard.Data.Service.Interfaces;
using System;
using System.Collections.Generic;
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
        public ActionResult Board(string boardName) {
            return View("Board");
        }
    }
}