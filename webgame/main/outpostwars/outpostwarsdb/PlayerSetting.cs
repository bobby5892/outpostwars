namespace outpostwarsdb
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PlayerSetting
    {
        [Key]
        public int idPlayer { get; set; }

        public bool sendEmails { get; set; }

        public bool sendPush { get; set; }

        public bool sendBrowserPush { get; set; }

        public bool alertOnBuildComplete { get; set; }

        public bool alertOnBeingAttacked { get; set; }

        public bool alertOnAttack { get; set; }

        public bool musicEnabled { get; set; }

        public bool soundEffectsEnabled { get; set; }

        public bool tutorialEnabled { get; set; }

        public virtual Player Player { get; set; }
    }
}
