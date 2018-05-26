namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CriticalError
    {
        public int id { get; set; }

        public DateTime? timestamp { get; set; }

        [Column(TypeName = "text")]
        public string Data { get; set; }

        [Column(TypeName = "text")]
        public string EntityValidationErrors { get; set; }

        [Column(TypeName = "text")]
        public string HelpLink { get; set; }

        [Column(TypeName = "text")]
        public string InnerException { get; set; }

        [Column(TypeName = "text")]
        public string Message { get; set; }

        [Column(TypeName = "text")]
        public string Source { get; set; }

        [Column(TypeName = "text")]
        public string StackTrace { get; set; }

        [Column(TypeName = "text")]
        public string TargetSite { get; set; }
    }
}
