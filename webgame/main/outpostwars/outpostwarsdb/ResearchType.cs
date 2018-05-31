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
    
    public partial class ResearchType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ResearchType()
        {
            this.ResearchCompleteds = new HashSet<ResearchCompleted>();
            this.ResearchCosts = new HashSet<ResearchCost>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public int requiresStationID { get; set; }
        public int stationLevelRequired { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResearchCompleted> ResearchCompleteds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResearchCost> ResearchCosts { get; set; }
    }
}
