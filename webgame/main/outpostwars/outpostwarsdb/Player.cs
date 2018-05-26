namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Player")]
    public partial class Player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Player()
        {
            AllianceLedgers = new HashSet<AllianceLedger>();
            AllianceMembers = new HashSet<AllianceMember>();
            FleetBuildings = new HashSet<FleetBuilding>();
            Fleets = new HashSet<Fleet>();
            Inventories = new HashSet<Inventory>();
            Logins = new HashSet<Login>();
            PlayerBuffs = new HashSet<PlayerBuff>();
            PlayerResources = new HashSet<PlayerResource>();
            ResearchCompleteds = new HashSet<ResearchCompleted>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(15)]
        public string characterName { get; set; }

        [Required]
        [StringLength(15)]
        public string firstName { get; set; }

        [Required]
        [StringLength(15)]
        public string lastName { get; set; }

        [Required]
        [StringLength(256)]
        public string email { get; set; }

        [StringLength(64)]
        public string passwordResetHash { get; set; }

        public DateTime? passwordHashExpiration { get; set; }

        [StringLength(255)]
        public string facebookToken { get; set; }

        [StringLength(255)]
        public string googleToken { get; set; }

        public DateTime createdAtTimestamp { get; set; }

        public DateTime updatedAtTimestamp { get; set; }

        public DateTime lastLoginTimestamp { get; set; }

        public bool? enabled { get; set; }

        public int allianceID { get; set; }

        [StringLength(64)]
        public string sourceClickID { get; set; }

        [StringLength(20)]
        public string sourceSub1 { get; set; }

        [StringLength(20)]
        public string sourceSub2 { get; set; }

        [StringLength(20)]
        public string sourceSub3 { get; set; }

        [StringLength(20)]
        public string sourceSub4 { get; set; }

        [StringLength(20)]
        public string sourceSub5 { get; set; }

        public bool firstLoginComplete { get; set; }

        public int sectorID { get; set; }

        public bool canLoginDuringMaintnence { get; set; }

        [Required]
        [StringLength(255)]
        public string CLSID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllianceLedger> AllianceLedgers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllianceMember> AllianceMembers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FleetBuilding> FleetBuildings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fleet> Fleets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventories { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Login> Logins { get; set; }

        public virtual Outpost Outpost { get; set; }

        public virtual Sector Sector { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerBuff> PlayerBuffs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlayerResource> PlayerResources { get; set; }

        public virtual PlayerSetting PlayerSetting { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResearchCompleted> ResearchCompleteds { get; set; }
    }
}
