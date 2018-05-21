namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GameSetting
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int hashExpirationHours { get; set; }

        [Key]
        [Column(Order = 1)]
        public decimal baseMovementSpeed { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool alllowLogins { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool maintnenceMode { get; set; }
    }
}
