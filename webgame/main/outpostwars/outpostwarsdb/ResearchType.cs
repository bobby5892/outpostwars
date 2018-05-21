namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ResearchType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ResearchType()
        {
            ResearchCompleteds = new HashSet<ResearchCompleted>();
            ResearchCosts = new HashSet<ResearchCost>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string name { get; set; }

        public int requiresStationID { get; set; }

        public int stationLevelRequired { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResearchCompleted> ResearchCompleteds { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResearchCost> ResearchCosts { get; set; }
    }
}
