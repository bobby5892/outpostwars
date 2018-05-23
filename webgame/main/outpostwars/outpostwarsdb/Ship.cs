namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ship
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ship()
        {
            FleetBuildings = new HashSet<FleetBuilding>();
            Fleets = new HashSet<Fleet>();
            ShipCosts = new HashSet<ShipCost>();
            ShipsLostLineItems = new HashSet<ShipsLostLineItem>();
            ShipsRemainingLineItems = new HashSet<ShipsRemainingLineItem>();
        }

        public int id { get; set; }

        public int name { get; set; }

        [Required]
        [StringLength(50)]
        public string icon { get; set; }

        [Required]
        [StringLength(50)]
        public string worldMapAnimationImage { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FleetBuilding> FleetBuildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fleet> Fleets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipCost> ShipCosts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipsLostLineItem> ShipsLostLineItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShipsRemainingLineItem> ShipsRemainingLineItems { get; set; }
    }
}
