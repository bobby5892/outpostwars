namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("fleetBuilding")]
    public partial class fleetBuilding
    {
        public int id { get; set; }

        public int idPlayer { get; set; }

        public int shipID { get; set; }

        public int qty { get; set; }

        public int completitionTimeReaminingSeconds { get; set; }

        public virtual Player Player { get; set; }

        public virtual Ship Ship { get; set; }
    }
}
