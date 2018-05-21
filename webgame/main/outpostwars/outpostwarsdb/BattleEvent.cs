namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BattleEvent")]
    public partial class BattleEvent
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BattleEvent()
        {
            ShipsLostLineItems = new HashSet<ShipsLostLineItem>();
            ShipsRemainingLineItems = new HashSet<ShipsRemainingLineItem>();
        }

        public int id { get; set; }

        public DateTime timestamp { get; set; }

        public int attackerID { get; set; }

        public int defenderID { get; set; }

        public int mapX { get; set; }

        public int mapY { get; set; }

        public int sectorID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipsLostLineItem> ShipsLostLineItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipsRemainingLineItem> ShipsRemainingLineItems { get; set; }
    }
}
