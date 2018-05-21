namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Station")]
    public partial class Station
    {
        public int id { get; set; }

        public int outpostID { get; set; }

        public int stationTypeID { get; set; }

        public int level { get; set; }

        public virtual Outpost Outpost { get; set; }

        public virtual StationType StationType { get; set; }
    }
}
