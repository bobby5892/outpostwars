namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ShipsLostLineItem
    {
        public int id { get; set; }

        public int battleID { get; set; }

        public int playerID { get; set; }

        public int shipID { get; set; }

        public int qty { get; set; }

        public virtual BattleEvent BattleEvent { get; set; }

        public virtual Ship Ship { get; set; }
    }
}
