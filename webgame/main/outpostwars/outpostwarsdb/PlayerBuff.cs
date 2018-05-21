namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlayerBuff")]
    public partial class PlayerBuff
    {
        public int id { get; set; }

        public int IdPlayer { get; set; }

        public int statID { get; set; }

        public int value { get; set; }

        public int countdownRemaining { get; set; }

        public virtual Player Player { get; set; }

        public virtual StatType StatType { get; set; }
    }
}
