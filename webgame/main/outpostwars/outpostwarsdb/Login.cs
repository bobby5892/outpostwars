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
    
    public partial class Login
    {
        public int id { get; set; }
        public System.DateTime timestamp { get; set; }
        public int idPlayer { get; set; }
        public bool success { get; set; }
        public string detail { get; set; }
        public string ip { get; set; }
        public string userAgent { get; set; }
        public int screenWidth { get; set; }
        public int screenHeight { get; set; }
        public bool isMobile { get; set; }
        public bool isTablet { get; set; }
        public bool isDesktop { get; set; }
    
        public virtual Player Player { get; set; }
    }
}
