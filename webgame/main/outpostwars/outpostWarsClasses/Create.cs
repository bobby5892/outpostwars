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
        #endregion

        #region AllianceLedger
        #endregion

        #region AllianceMember
        #endregion

        #region AllianceStore
        #endregion

        #region AllianceWallet
        #endregion

        #region BannedIP
        #endregion

        #region BannedUserAgent
        #endregion

        #region BattleEvent
        #endregion

        #region Fleet
        #endregion

        #region FleetBuilding
        #endregion

        #region GameSetting
        #endregion

        #region Inventory
        #endregion

        #region Item
        #endregion

        #region Log
        #endregion

        #region Login
        #endregion

        #region Messages
        #endregion

        #region Node
        #endregion

        #region Outpost
        #endregion

        #region PlayerBuff
        #endregion

        #region  PlayerResource
        #endregion

        #region PlayerSetting
        #endregion

        #region ResearchCompleted
        #endregion

        #region ResearchCost
        #endregion

        #region ResearchTree
        #endregion

        #region ResearchType
        #endregion

        #region ReourceType
        #endregion

        #region Ship
        #endregion

        #region ShipCost
        #endregion

        #region ShipsLostLineItem
        #endregion

        #region ShipsRemainingLineItem
        #endregion

        #region Station
        #endregion

        #region StationTypes
        #endregion

        #region StationUpgradesCost
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

            if(newPlayer.enabled == null)
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
            catch(DbEntityValidationException ex)
            {
               LogCriticalError(ex);
            }
           // Only hapens if problem
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
            if(ex.Data != null){
                error.Data = (string)ex.Data.ToString();
            } else {
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

    }
}
