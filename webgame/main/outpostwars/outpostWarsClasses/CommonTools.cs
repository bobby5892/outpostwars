﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using outpostwarsdb;
namespace outpostWarsClasses
{
    public static class CommonTools
    {
        #region methods
        // Random Number Generator and Random String
        private static Random random = new Random();
        public static int RandomInt(int max)
        {
            return random.Next(max);
        }
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        /// <summary>
        /// Use Entity Framework In outpostDB to lookup playerid
        /// </summary>
        /// <param name="CLSID"></param>
        /// <returns></returns>
        public static int LookupPlayerIDbyCSLID(string CLSID)
        {
            outpostwarsEntities entities = new outpostwarsEntities();
            Player player = (Player)entities.Players
                    .Where(b => b.CLSID == CLSID)
                    .FirstOrDefault();
            return player.id;
        }
        #endregion

        #region structs
        /// <summary>
        /// Struct - For Passing around Coordinates
        /// </summary>
        public struct GridLocation
        {
            int X;
            int Y;
            int SectorID;
        }
        #endregion

       
    
    }
}
