namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Node
    {
        public int id { get; set; }

        public int mapX { get; set; }

        public int mapY { get; set; }

        public int sectorID { get; set; }

        public int resourceTypeID { get; set; }

        public int unitsReamining { get; set; }

        public virtual ResourceType ResourceType { get; set; }

        public virtual Sector Sector { get; set; }
    }
}
