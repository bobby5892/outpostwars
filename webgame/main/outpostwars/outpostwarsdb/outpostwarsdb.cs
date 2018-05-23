namespace outpostwarsdb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class outpostwarsdb : DbContext
    {
        public outpostwarsdb()
            : base("name=outpostwarsdb")
        {
        }

        public virtual DbSet<Alliance> Alliances { get; set; }
        public virtual DbSet<AllianceLedger> AllianceLedgers { get; set; }
        public virtual DbSet<AllianceMember> AllianceMembers { get; set; }
        public virtual DbSet<AllianceWallet> AllianceWallets { get; set; }
        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<BattleEvent> BattleEvents { get; set; }
        public virtual DbSet<fleetBuilding> fleetBuildings { get; set; }
        public virtual DbSet<Fleet> Fleets { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Node> Nodes { get; set; }
        public virtual DbSet<Outpost> Outposts { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlayerBuff> PlayerBuffs { get; set; }
        public virtual DbSet<PlayerResource> PlayerResources { get; set; }
        public virtual DbSet<PlayerSetting> PlayerSettings { get; set; }
        public virtual DbSet<ResearchCompleted> ResearchCompleteds { get; set; }
        public virtual DbSet<ResearchCost> ResearchCosts { get; set; }
        public virtual DbSet<ResearchTree> ResearchTrees { get; set; }
        public virtual DbSet<ResearchType> ResearchTypes { get; set; }
        public virtual DbSet<ResourceType> ResourceTypes { get; set; }
        public virtual DbSet<Sector> Sectors { get; set; }
        public virtual DbSet<ShipCost> ShipCosts { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }
        public virtual DbSet<ShipsLostLineItem> ShipsLostLineItems { get; set; }
        public virtual DbSet<ShipsRemainingLineItem> ShipsRemainingLineItems { get; set; }
        public virtual DbSet<Station> Stations { get; set; }
        public virtual DbSet<StationType> StationTypes { get; set; }
        public virtual DbSet<StationUpgradesCost> StationUpgradesCosts { get; set; }
        public virtual DbSet<StatType> StatTypes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<AllianceStore> AllianceStores { get; set; }
        public virtual DbSet<GameSetting> GameSettings { get; set; }
        public virtual DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alliance>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Alliance>()
                .Property(e => e.rank1title)
                .IsUnicode(false);

            modelBuilder.Entity<Alliance>()
                .Property(e => e.rank2title)
                .IsUnicode(false);

            modelBuilder.Entity<Alliance>()
                .Property(e => e.rank3title)
                .IsUnicode(false);

            modelBuilder.Entity<Alliance>()
                .Property(e => e.rank4title)
                .IsUnicode(false);

            modelBuilder.Entity<Alliance>()
                .Property(e => e.rank5title)
                .IsUnicode(false);

            modelBuilder.Entity<Alliance>()
                .HasMany(e => e.AllianceLedgers)
                .WithRequired(e => e.Alliance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alliance>()
                .HasMany(e => e.AllianceMembers)
                .WithRequired(e => e.Alliance)
                .HasForeignKey(e => e.idAlliance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alliance>()
                .HasMany(e => e.AllianceStores)
                .WithRequired(e => e.Alliance)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Alliance>()
                .HasOptional(e => e.AllianceWallet)
                .WithRequired(e => e.Alliance);

            modelBuilder.Entity<Auth>()
                .Property(e => e.passwordHash)
                .IsUnicode(false);

            modelBuilder.Entity<BattleEvent>()
                .HasMany(e => e.ShipsLostLineItems)
                .WithRequired(e => e.BattleEvent)
                .HasForeignKey(e => e.battleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BattleEvent>()
                .HasMany(e => e.ShipsRemainingLineItems)
                .WithRequired(e => e.BattleEvent)
                .HasForeignKey(e => e.battleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .Property(e => e.icon)
                .IsUnicode(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.AllianceLedgers)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Item>()
                .HasMany(e => e.AllianceStores)
                .WithRequired(e => e.Item)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.action)
                .IsUnicode(false);

            modelBuilder.Entity<Log>()
                .Property(e => e.details)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.detail)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.ip)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.userAgent)
                .IsUnicode(false);

            modelBuilder.Entity<Outpost>()
                .HasMany(e => e.Stations)
                .WithRequired(e => e.Outpost)
                .HasForeignKey(e => e.outpostID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.characterName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.userName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.passwordResetHash)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.facebookToken)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.googleToken)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.sourceSub1)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.sourceSub2)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.sourceSub3)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.sourceSub4)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.sourceSub5)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.salt)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.AllianceLedgers)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.AllianceMembers)
                .WithRequired(e => e.Player)
                .HasForeignKey(e => e.idPlayer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Auths)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.fleetBuildings)
                .WithRequired(e => e.Player)
                .HasForeignKey(e => e.idPlayer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Fleets)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.Logins)
                .WithRequired(e => e.Player)
                .HasForeignKey(e => e.idPlayer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasOptional(e => e.Outpost)
                .WithRequired(e => e.Player);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.PlayerBuffs)
                .WithRequired(e => e.Player)
                .HasForeignKey(e => e.IdPlayer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.PlayerResources)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Player>()
                .HasOptional(e => e.PlayerSetting)
                .WithRequired(e => e.Player);

            modelBuilder.Entity<Player>()
                .HasMany(e => e.ResearchCompleteds)
                .WithRequired(e => e.Player)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResearchCost>()
                .Property(e => e.costModifierPerLevel)
                .HasPrecision(4, 2);

            modelBuilder.Entity<ResearchType>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ResearchType>()
                .HasMany(e => e.ResearchCompleteds)
                .WithRequired(e => e.ResearchType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResearchType>()
                .HasMany(e => e.ResearchCosts)
                .WithRequired(e => e.ResearchType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResourceType>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ResourceType>()
                .HasMany(e => e.Nodes)
                .WithRequired(e => e.ResourceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ResourceType>()
                .HasMany(e => e.PlayerResources)
                .WithRequired(e => e.ResourceType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.Fleets)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.Nodes)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.Outposts)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sector>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Sector)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ship>()
                .Property(e => e.icon)
                .IsUnicode(false);

            modelBuilder.Entity<Ship>()
                .Property(e => e.worldMapAnimationImage)
                .IsUnicode(false);

            modelBuilder.Entity<Ship>()
                .HasMany(e => e.fleetBuildings)
                .WithRequired(e => e.Ship)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ship>()
                .HasMany(e => e.Fleets)
                .WithRequired(e => e.Ship)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ship>()
                .HasMany(e => e.ShipCosts)
                .WithOptional(e => e.Ship)
                .HasForeignKey(e => e.shipTypeID);

            modelBuilder.Entity<Ship>()
                .HasMany(e => e.ShipsLostLineItems)
                .WithRequired(e => e.Ship)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ship>()
                .HasMany(e => e.ShipsRemainingLineItems)
                .WithRequired(e => e.Ship)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StationType>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<StationType>()
                .Property(e => e.icon)
                .IsUnicode(false);

            modelBuilder.Entity<StationType>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<StationType>()
                .HasMany(e => e.Stations)
                .WithRequired(e => e.StationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StationType>()
                .HasMany(e => e.StationUpgradesCosts)
                .WithRequired(e => e.StationType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StatType>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<StatType>()
                .HasMany(e => e.PlayerBuffs)
                .WithRequired(e => e.StatType)
                .HasForeignKey(e => e.statID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GameSetting>()
                .Property(e => e.baseMovementSpeed)
                .HasPrecision(18, 5);

            modelBuilder.Entity<Message>()
                .Property(e => e.contents)
                .IsUnicode(false);
        }
    }
}
