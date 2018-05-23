namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BannedUserAgent")]
    public partial class BannedUserAgent
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "text")]
        public string userAgent { get; set; }
    }
}
