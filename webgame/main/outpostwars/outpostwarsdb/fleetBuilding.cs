//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    
    public partial class FleetBuilding
    {
        public int id { get; set; }
        public int idPlayer { get; set; }
        public int shipID { get; set; }
        public int qty { get; set; }
        public int completitionTimeReaminingSeconds { get; set; }
    
        public virtual Player Player { get; set; }
        public virtual Ship Ship { get; set; }
    }
}
