namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlayerResource
    {
        public int id { get; set; }

        public int resourceTypeID { get; set; }

        public int qty { get; set; }

        public int playerID { get; set; }

        public virtual Player Player { get; set; }

        public virtual ResourceType ResourceType { get; set; }
    }
}
