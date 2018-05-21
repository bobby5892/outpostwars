namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Message")]
    public partial class Message
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int player1ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int player2ID { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int allianceID { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string contents { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool isPlayerToPlayer { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool isToClan { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime timestamp { get; set; }
    }
}
