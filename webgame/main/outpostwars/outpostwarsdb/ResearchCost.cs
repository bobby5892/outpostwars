namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ResearchCost
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int researchTypeID { get; set; }

        public int resourceID1 { get; set; }

        public int resourceID2 { get; set; }

        public int resourceID3 { get; set; }

        public int resourceID4 { get; set; }

        public int resourceID5 { get; set; }

        public int resourceQty1 { get; set; }

        public int resourceQty2 { get; set; }

        public int resourceQty3 { get; set; }

        public int resourceQty4 { get; set; }

        public int resourceQty5 { get; set; }

        public decimal costModifierPerLevel { get; set; }

        public int maxLevel { get; set; }

        public virtual ResearchType ResearchType { get; set; }
    }
}
