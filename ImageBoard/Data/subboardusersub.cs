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
    
    public partial class subboardusersub
    {
        public int id { get; set; }
        public int subBoard_id { get; set; }
        public string subBoardName { get; set; }
        public int user_id { get; set; }
        public Nullable<bool> isFavorite { get; set; }
    
        public virtual subboard subboard { get; set; }
        public virtual user user { get; set; }
    }
}
