//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImageBoard.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class subboardpostjoin
    {
        public int id { get; set; }
        public int subBoard_id { get; set; }
        public string subBoardName { get; set; }
        public int post_id { get; set; }
    
        public virtual post post { get; set; }
        public virtual subboard subboard { get; set; }
    }
}
