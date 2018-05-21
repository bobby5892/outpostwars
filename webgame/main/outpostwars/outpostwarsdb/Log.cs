namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Log")]
    public partial class Log
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id { get; set; }

        public int playerID { get; set; }

        [Required]
        [StringLength(30)]
        public string action { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string details { get; set; }

        public DateTime timestamp { get; set; }

        public bool isCritical { get; set; }

        public bool isWarning { get; set; }
    }
}
