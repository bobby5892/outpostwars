namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SectorMap")]
    public partial class SectorMap
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int? x { get; set; }

        public int? y { get; set; }

        [StringLength(50)]
        public string objectType { get; set; }

        public int? objectID { get; set; }

        public int? sectorID { get; set; }
    }
}
