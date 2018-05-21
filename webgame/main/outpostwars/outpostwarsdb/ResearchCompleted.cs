namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResearchCompleted")]
    public partial class ResearchCompleted
    {
        public int id { get; set; }

        public int playerID { get; set; }

        public int researchTypeID { get; set; }

        public int level { get; set; }

        public virtual Player Player { get; set; }

        public virtual ResearchType ResearchType { get; set; }
    }
}
