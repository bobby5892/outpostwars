namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventory")]
    public partial class Inventory
    {
        public int id { get; set; }

        public int? itemID { get; set; }

        public int? qty { get; set; }

        public int? playerID { get; set; }

        public virtual Item Item { get; set; }

        public virtual Player Player { get; set; }
    }
}
