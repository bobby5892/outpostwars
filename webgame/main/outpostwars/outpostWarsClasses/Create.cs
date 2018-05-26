using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using outpostwarsdb;
namespace outpostWarsClasses
{
    public class Create
    {
        #region CompleteObjects
        public bool CreateEverything(Player newPlayer)
        {
            bool success = false;
            // Get an Open Sector
            Sector chosen = Find.FindSector(true);
            // Put the Player in the chosen sector
            newPlayer.sectorID = chosen.id;
            // Create the Player
            success = CreatePlayer(newPlayer);
            // Get The Player ID
            int playerID = Find.FindPlayerIDbyCSLID(newPlayer.CLSID);
            // Find and Set a GridLocation in new outpost
            Outpost newOutpost = new Outpost();

            // Open Location
           // CommonTools.GridLocation location = FindOpenLocationInSector(chosen);

            return success;
        }
        #endregion
        #region Individual Objects

        #region Alliance
        public bool CreateAlliance(Alliance alliance)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Alliances.Add(alliance);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
            #endregion

        #region AllianceLedger
            public bool CreateAllianceLedger(AllianceLedger allianceLedger)
            {
                outpostwarsEntities entities = new outpostwarsEntities();
                try
                {
                    // Add tew New Player into the player Collection
                    entities.AllianceLedgers.Add(allianceLedger);
                    // Save changes
                    return (entities.SaveChanges() == 1);
                }
                catch (DbEntityValidationException ex)
                {
                    LogCriticalError(ex);
                }
                return false;
            }
        #endregion

        #region AllianceMember
        public bool CreateAllianceMember(AllianceMember allianceMember)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.AllianceMembers.Add(allianceMember);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region AllianceStore
        public bool CreateAllianceStore(AllianceStore allianceStore)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.AllianceStores.Add(allianceStore);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region AllianceWallet
        public bool CreateAllianceWallet(AllianceWallet allianceWallet)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.AllianceWallets.Add(allianceWallet);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region BannedIP
        public bool CreateBannedIP(BannedIP bannedIP)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.BannedIPs.Add(bannedIP);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region BannedUserAgent
        public bool CreateBannedUserAgent(BannedUserAgent bannedUserAgent)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.BannedUserAgents.Add(bannedUserAgent);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region BattleEvent
        public bool CreateBattleEvent(BattleEvent battleEvent)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.BattleEvents.Add(battleEvent);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region CriticalError
        /// <summary>
        /// A Common Method for Passing Critical Errors to Database
        /// 
        /// </summary>
        /// <param name="ex">DbEntityValidationException</param>
        public void LogCriticalError(DbEntityValidationException ex)
        {
            // Create an entity of error
            outpostwarsEntities entities = new outpostwarsEntities();
            CriticalError error = new CriticalError();
            if (ex.Data != null)
            {
                error.Data = (string)ex.Data.ToString();
            }
            else
            {
                error.Data = " ";
            }
            if (error.HelpLink != null)
            {
                error.HelpLink = (string)ex.HelpLink.ToString();
            }
            else
            {
                error.HelpLink = " ";
            }
            if (error.EntityValidationErrors != null)
            {
                error.EntityValidationErrors = (string)ex.EntityValidationErrors.ToString();
            }
            else
            {
                error.EntityValidationErrors = " ";
            }
            if (error.InnerException != null)
            {
                error.InnerException = (string)ex.InnerException.ToString();
            }
            else
            {
                error.InnerException = " ";
            }
            if (error.Message != null)
            {
                error.Message = (string)ex.Message.ToString();
            }
            else
            {
                error.Message = " ";
            }
            if (error.Source != null)
            {
                error.Source = (string)ex.Source.ToString();
            }
            else
            {
                error.Source = " ";
            }
            if (error.StackTrace != null)
            {
                error.StackTrace = (string)ex.StackTrace.ToString();
            }
            else
            {
                error.StackTrace = " ";
            }
            if (error.TargetSite != null)
            {
                error.TargetSite = (string)ex.TargetSite.ToString();
            }
            else
            {
                error.TargetSite = " ";
            }


            // Add it to be saved
            entities.CriticalErrors.Add(error);

            // Now to save it
            entities.SaveChanges();
        }
        #endregion

        #region Fleet
        public bool CreateFleet(Fleet fleet)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Fleets.Add(fleet);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region FleetBuilding
        public bool CreateFleetBuilding(FleetBuilding fleetBuilding)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.FleetBuildings.Add(fleetBuilding);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region GameSetting
        public bool CreateGameSetting(GameSetting gameSetting)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.GameSettings.Add(gameSetting);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Inventory
        public bool CreateInventory(Inventory inventory)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Inventories.Add(inventory);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Item
        public bool CreateItem(Item item)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Items.Add(item);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Log
        public bool CreateLog(Log log)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Logs.Add(log);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Login
        public bool CreateLogin(Login login)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Logins.Add(login);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Message
        public bool CreateMessage(Message message)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Messages.Add(message);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Node
        public bool CreateNode(Node node)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Nodes.Add(node);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Outpost
        public bool CreateOutpost(Outpost outpost)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Outposts.Add(outpost);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Player

        public bool CreatePlayer(Player newPlayer)
        {

            // Build a generic character name
            if (newPlayer.characterName == null)
            {
                newPlayer.characterName = "Monkey" + CommonTools.RandomString(9); // Max 15
            }
            // Set First Name / Last name 
            newPlayer.firstName = "Space";
            newPlayer.lastName = "Monkey";

            // Random String - not implemented
            if (newPlayer.passwordResetHash == null)
            {
                newPlayer.passwordResetHash = CommonTools.RandomString(64);
            }
            // Set Current Time
            newPlayer.createdAtTimestamp = DateTime.Now;
            // Set Last Update Time
            newPlayer.updatedAtTimestamp = DateTime.Now;
            // Set Last Login Time
            newPlayer.lastLoginTimestamp = DateTime.Now;

            if (newPlayer.enabled == null)
            {
                newPlayer.enabled = true;
            }
            // Not In Alliance = -1
            if (newPlayer.allianceID == 0)
            {
                newPlayer.allianceID = -1;
            }
            try
            {
                outpostwarsdb.outpostwarsEntities entities = new outpostwarsEntities();
                // Add tew New Player into the player Collection
                entities.Players.Add(newPlayer);
          

                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            // Only hapens if problem
            return false;

        }
        #endregion

        #region PlayerBuff
        public bool CreatePlayerBuff(PlayerBuff playerBuff)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.PlayerBuffs.Add(playerBuff);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region  PlayerResource
        public bool CreatePlayerResource(PlayerResource playerResource)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.PlayerResources.Add(playerResource);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region PlayerSetting
        public bool CreatePlayerSetting(PlayerSetting playerSetting)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.PlayerSettings.Add(playerSetting);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region ResearchCompleted
        public bool CreateResearchCompleted(ResearchCompleted researchCompleted)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResearchCompleteds.Add(researchCompleted);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region ResearchCost
        public bool CreateResearchCost(ResearchCost researchCost)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResearchCosts.Add(researchCost);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region ResearchTree
        public bool CreateResearchTree(ResearchTree researchTree)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResearchTrees.Add(researchTree);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region ResearchType
        public bool CreateResearchType(ResearchType researchType)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResearchTypes.Add(researchType);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region ResourceType
        public bool CreateResourceType(ResourceType resourceType)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResourceTypes.Add(resourceType);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Sector
        public bool CreateSector(Sector sector)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Sectors.Add(sector);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region SectorMap
        public bool CreateSectorMap(SectorMap sectorMap)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.SectorMaps.Add(sectorMap);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
           
        }
        #endregion

        #region Ship
        public bool CreateShip(Ship ship)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Ships.Add(ship);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region ShipCost
        public bool CreateShipCost(ShipCost shipCost)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ShipCosts.Add(shipCost);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region ShipsLostLineItem
        public bool CreateShipsLostLineItem(ShipsLostLineItem shipsLostLineItem)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ShipsLostLineItems.Add(shipsLostLineItem);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region ShipsRemainingLineItem
        public bool CreateShipsRemainingLineItem(ShipsRemainingLineItem shipsRemainingLineItem)
        {
             outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ShipsRemainingLineItems.Add(shipsRemainingLineItem);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region Station
        public bool CreateStation(Station station)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Stations.Add(station);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region StationType
        public bool CreateStationType(StationType stationType)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.StationTypes.Add(stationType);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #region StationUpgradesCost
        public bool CreateStationUpgradesCost(StationUpgradesCost stationUpgradesCost)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.StationUpgradesCosts.Add(stationUpgradesCost);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }

        #endregion

        #region StatType
        public bool CreateStatType(StatType statType)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.StatTypes.Add(statType);
                // Save changes
                return (entities.SaveChanges() == 1);
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return false;
        }
        #endregion

        #endregion
    }
}
