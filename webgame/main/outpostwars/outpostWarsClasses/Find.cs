using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using outpostwarsdb;
using System.Data.Entity;

namespace outpostWarsClasses
{
    public static class Find
    {
        public static outpostwarsEntities outpostwarsEntities;
        /// <summary>
        /// Retrn a Sector 
        /// </summary>
        /// <param name="payToWin">Bool - Pay To Win Sector Or No</param>
        /// <returns></returns>
        public static Sector FindSector(bool payToWin)
        {
            return outpostwarsEntities.Sectors.FirstOrDefault
                 (sector =>
                     sector.allowPayToWinStore == payToWin &&
                     sector.enabled == true &&
                     sector.allowsNewPlayers == true &&
                     sector.visibleToPlayers == true
            );
        }

        public static int FindPlayerIDbyCSLID(string CLSID)
        {
            Player player = (Player)outpostwarsEntities.Players
                    .Where(b => b.CLSID == CLSID)
                    .FirstOrDefault();
            return player.id;
        }

        public static GridLocation FindOpenLocationInSector(Sector sector)
        {
            // Create a List of Grids that Already Exist
            List<GridLocation> locations = new List<GridLocation>();

            /*
            var lstObject1 = listObject1.Select(item -> item.ObjectId).ToArray();  
            List<Object2> listObject2 = da.dbsetObject2.Where(p=> lstObject1.Contains(p.ObjectId)).ToList();
             */

            // outpostwarsEntities.SectorMaps.Select(map => map.id)

            // NOT FINISHED - ROB IS HERE
            GridLocation temp = new GridLocation();
            
            return temp;

        }
    }
}