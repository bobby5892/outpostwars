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
    
    public partial class AllianceWallet
    {
        public int idAlliance { get; set; }
        public int resourceID1 { get; set; }
        public int resourceID2 { get; set; }
        public int resourceID3 { get; set; }
        public int resourceID4 { get; set; }
        public int resourceID5 { get; set; }
        public int resourceQty1 { get; set; }
        public int resourceQty2 { get; set; }
        public int resourceQty3 { get; set; }
        public int resourceQty4 { get; set; }
        public int resourceQty5 { get; set; }
        public bool showResource1ToAlliance { get; set; }
        public bool showResource2ToAlliance { get; set; }
        public bool showResource3ToAlliance { get; set; }
        public bool showResource4ToAlliance { get; set; }
        public bool showResource5ToAlliance { get; set; }
    
        public virtual Alliance Alliance { get; set; }
    }
}
