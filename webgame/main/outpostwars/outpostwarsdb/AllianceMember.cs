namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AllianceMember")]
    public partial class AllianceMember
    {
        public int id { get; set; }

        public int idPlayer { get; set; }

        public int idAlliance { get; set; }

        public int rank { get; set; }

        public DateTime timestampJoin { get; set; }

        public int currency { get; set; }

        public virtual Alliance Alliance { get; set; }

        public virtual Player Player { get; set; }
    }
}
