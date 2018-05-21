namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alliance")]
    public partial class Alliance
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alliance()
        {
            AllianceLedgers = new HashSet<AllianceLedger>();
            AllianceMembers = new HashSet<AllianceMember>();
            AllianceStores = new HashSet<AllianceStore>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(20)]
        public string name { get; set; }

        public int icon { get; set; }

        public int banner { get; set; }

        [Required]
        [StringLength(10)]
        public string rank1title { get; set; }

        [Required]
        [StringLength(10)]
        public string rank2title { get; set; }

        [Required]
        [StringLength(10)]
        public string rank3title { get; set; }

        [Required]
        [StringLength(10)]
        public string rank4title { get; set; }

        [Required]
        [StringLength(10)]
        public string rank5title { get; set; }

        public int permInviteMembers { get; set; }

        public int permRemoveMembers { get; set; }

        public int permPromoteMember { get; set; }

        public int permKickMember { get; set; }

        public int permEditClan { get; set; }

        public int permEditPerms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllianceLedger> AllianceLedgers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllianceMember> AllianceMembers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AllianceStore> AllianceStores { get; set; }

        public virtual AllianceWallet AllianceWallet { get; set; }
    }
}
