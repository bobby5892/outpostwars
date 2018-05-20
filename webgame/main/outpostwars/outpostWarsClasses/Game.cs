using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outpostWarsClasses
{
    public class Game
    {
        /// <summary>
        /// The version of the game running
        /// </summary>
        public string version;

        /// <summary>
        ///  Is there a tested connection to the login server
        /// </summary>
       public bool loginServerAvailable;

        /// <summary>
        /// Is there a tested database server available
        /// </summary>
        public bool databaseServerAvailable;
        /// <summary>
        /// Default Constructor Passes a version to the classes
        /// </summary>
        /// <param name="version">This is a string in a 1.1.1 etc format</param>
        public Game(string version)
        {
            this.version = version;
            this.loginServerAvailable = false;
            this.databaseServerAvailable = false;
        }


    }
}
