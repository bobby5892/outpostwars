using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using outpostwarsdb;
namespace outpostWarsClasses
{
    public class Player  : outpostwarsdb.Player
    {
       
        // REFACTOR - 
   
        public int createPlayer(string clsid, string email, string clickID, string subID1, string subID2,
            string subID3, string subID4, string subID5)
        {


            Player newPlayer = new Player(); // the blanks are for clickID and 5 sub IDs (Marketing)
                                             // Set Default Player Values
           
            // Set received from ASP NET Succesfull Registration
            newPlayer.email = email;
            newPlayer.CLSID = clsid;
            newPlayer.sourceClickID = clickID;
            newPlayer.sourceSub1 = subID1;
            newPlayer.sourceSub2 = subID2;
            newPlayer.sourceSub3 = subID3;
            newPlayer.sourceSub4 = subID4;
            newPlayer.sourceSub5 = subID5;
            // Build a generic character name
            newPlayer.characterName = "Monkey" + CommonTools.RandomString(9); // Max 15
            // Set First Name / Last name 
            newPlayer.firstName = "Space";
            newPlayer.lastName = "Monkey";

            // Random String - not implemented
            newPlayer.passwordResetHash = CommonTools.RandomString(64);
            // Later will store Facebook Oath Token
            newPlayer.facebookToken = null;
            // Later will store Google Oath Token
            newPlayer.googleToken = null;
            // Set Current Time
            newPlayer.createdAtTimestamp = DateTime.Now;
            // Set Last Update Time
            newPlayer.updatedAtTimestamp = DateTime.Now;
            // Set Last Login Time
            newPlayer.lastLoginTimestamp = DateTime.Now;
            //Set Account enable
            newPlayer.enabled = true;
            // Not In Alliance = -1

            newPlayer.allianceID = -1;
            outpostwarsEntities entities = new outpostwarsEntities();
            // Add tew New Player into the player Collection
            entities.Players.Add((outpostwarsdb.Player) newPlayer);
            // Save changes
            entities.SaveChanges();

            // Lets then grab the player ID
            return CommonTools.LookupPlayerIDbyCSLID(clsid);

        }
    }
}
