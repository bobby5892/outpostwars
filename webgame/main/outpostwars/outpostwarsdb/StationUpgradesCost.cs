namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StationUpgradesCost")]
    public partial class StationUpgradesCost
    {
        public int id { get; set; }

        public int stationTypeID { get; set; }

        public int level { get; set; }

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

        public bool openToPlayers { get; set; }

        public virtual StationType StationType { get; set; }
    }
}
