namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ResearchTree")]
    public partial class ResearchTree
    {
        public int id { get; set; }

        public int researchTreeParentID { get; set; }

        public int researchTreeChild1ID { get; set; }

        public int researchTreeChild2ID { get; set; }

        public int researchTreeChild3ID { get; set; }
    }
}
