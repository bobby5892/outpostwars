namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AllianceLedger")]
    public partial class AllianceLedger
    {
        public int id { get; set; }

        public int playerID { get; set; }

        public DateTime timestamp { get; set; }

        public int resourceType { get; set; }

        public int value { get; set; }

        public int allianceID { get; set; }

        public int itemID { get; set; }

        public virtual Alliance Alliance { get; set; }

        public virtual Item Item { get; set; }

        public virtual Player Player { get; set; }
    }
}
