namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Fleet
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int playerID { get; set; }

        public int shipID { get; set; }

        public int qty { get; set; }

        public bool showOnWorldMap { get; set; }

        public int mapX { get; set; }

        public int mapY { get; set; }

        public int sectorID { get; set; }

        public virtual Player Player { get; set; }

        public virtual Sector Sector { get; set; }

        public virtual Ship Ship { get; set; }
    }
}
