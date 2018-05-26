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
        #region Alliance
        public int CreateAlliance(Alliance alliance)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Alliances.Add(alliance);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
            #endregion

        #region AllianceLedger
            public int CreateAllianceLedger(AllianceLedger allianceLedger)
            {
                outpostwarsEntities entities = new outpostwarsEntities();
                try
                {
                    // Add tew New Player into the player Collection
                    entities.AllianceLedgers.Add(allianceLedger);
                    // Save changes
                    return entities.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    LogCriticalError(ex);
                }
                return 0;
            }
        #endregion

        #region AllianceMember
        public int CreateAllianceMember(AllianceMember allianceMember)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.AllianceMembers.Add(allianceMember);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region AllianceStore
        public int CreateAllianceStore(AllianceStore allianceStore)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.AllianceStores.Add(allianceStore);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region AllianceWallet
        public int CreateAllianceWallet(AllianceWallet allianceWallet)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.AllianceWallets.Add(allianceWallet);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region BannedIP
        public int CreateBannedIP(BannedIP bannedIP)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.BannedIPs.Add(bannedIP);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region BannedUserAgent
        public int CreateBannedUserAgent(BannedUserAgent bannedUserAgent)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.BannedUserAgents.Add(bannedUserAgent);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region BattleEvent
        public int CreateBattleEvent(BattleEvent battleEvent)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.BattleEvents.Add(battleEvent);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
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
        public int CreateFleet(Fleet fleet)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Fleets.Add(fleet);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region FleetBuilding
        public int CreateFleetBuilding(FleetBuilding fleetBuilding)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.FleetBuildings.Add(fleetBuilding);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region GameSetting
        public int CreateGameSetting(GameSetting gameSetting)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.GameSettings.Add(gameSetting);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Inventory
        public int CreateInventory(Inventory inventory)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Inventories.Add(inventory);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Item
        public int CreateItem(Item item)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Items.Add(item);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Log
        public int CreateLog(Log log)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Logs.Add(log);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Login
        public int CreateLogin(Login login)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Logins.Add(login);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Message
        public int CreateMessage(Message message)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Messages.Add(message);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Node
        public int CreateNode(Node node)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Nodes.Add(node);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Outpost
        public int CreateOutpost(Outpost outpost)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Outposts.Add(outpost);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Player

        public int CreatePlayer(Player newPlayer)
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
                // Save changes
                int rowChanges = entities.SaveChanges();

                return rowChanges;
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            // Only hapens if problem
            return 0;

        }
        #endregion

        #region PlayerBuff
        public int CreatePlayerBuff(PlayerBuff playerBuff)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.PlayerBuffs.Add(playerBuff);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region  PlayerResource
        public int CreatePlayerResource(PlayerResource playerResource)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.PlayerResources.Add(playerResource);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region PlayerSetting
        public int CreatePlayerSetting(PlayerSetting playerSetting)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.PlayerSettings.Add(playerSetting);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region ResearchCompleted
        public int CreateResearchCompleted(ResearchCompleted researchCompleted)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResearchCompleteds.Add(researchCompleted);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region ResearchCost
        public int CreateResearchCost(ResearchCost researchCost)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResearchCosts.Add(researchCost);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region ResearchTree
        public int CreateResearchTree(ResearchTree researchTree)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResearchTrees.Add(researchTree);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region ResearchType
        public int CreateResearchType(ResearchType researchType)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResearchTypes.Add(researchType);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region ResourceType
        public int CreateResourceType(ResourceType resourceType)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ResourceTypes.Add(resourceType);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Sector
        public int CreateSector(Sector sector)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Sectors.Add(sector);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Ship
        public int CreateShip(Ship ship)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Ships.Add(ship);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region ShipCost
        public int CreateShipCost(ShipCost shipCost)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ShipCosts.Add(shipCost);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region ShipsLostLineItem
        public int CreateShipsLostLineItem(ShipsLostLineItem shipsLostLineItem)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ShipsLostLineItems.Add(shipsLostLineItem);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region ShipsRemainingLineItem
        public int CreateShipsRemainingLineItem(ShipsRemainingLineItem shipsRemainingLineItem)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.ShipsRemainingLineItems.Add(shipsRemainingLineItem);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region Station
        public int CreateStation(Station station)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.Stations.Add(station);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region StationType
        public int CreateStationType(StationType stationType)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.StationTypes.Add(stationType);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion

        #region StationUpgradesCost
        public int CreateStationUpgradesCost(StationUpgradesCost stationUpgradesCost)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.StationUpgradesCosts.Add(stationUpgradesCost);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }

        #endregion

        #region StatType
        public int CreatStatType(StatType statType)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            try
            {
                // Add tew New Player into the player Collection
                entities.StatTypes.Add(statType);
                // Save changes
                return entities.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                LogCriticalError(ex);
            }
            return 0;
        }
        #endregion
    }
}
