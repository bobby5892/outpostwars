namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AllianceWallet")]
    public partial class AllianceWallet
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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
