using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ImageBoard.Helpers.Exceptions
{
    public class BoardExistsException: Exception
    {
        public BoardExistsException() : base("This Board doesn't exist")
        { }
    }
}