namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class StatType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatType()
        {
            PlayerBuffs = new HashSet<PlayerBuff>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(10)]
        public string name { get; set; }

        public bool visibleToPlayer { get; set; }

        public bool forFleet { get; set; }

        public bool forOutpost { get; set; }

        public int? typeID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerBuff> PlayerBuffs { get; set; }
    }
}
