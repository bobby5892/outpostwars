namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        public int id { get; set; }

        public DateTime timestamp { get; set; }

        public int idPlayer { get; set; }

        public bool success { get; set; }

        [Column(TypeName = "text")]
        public string detail { get; set; }

        [Required]
        [StringLength(128)]
        public string ip { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string userAgent { get; set; }

        public int screenWidth { get; set; }

        public int screenHeight { get; set; }

        public bool isMobile { get; set; }

        public bool isTablet { get; set; }

        public bool isDesktop { get; set; }

        public virtual Player Player { get; set; }
    }
}
