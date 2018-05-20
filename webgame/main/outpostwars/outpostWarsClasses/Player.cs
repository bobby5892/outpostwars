using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outpostWarsClasses
{
    public class Player
    {
        /* Private Variables */

        /// <summary>
        /// Player ID # from Database
        /// </summary>
        int id;
     
        /// <summary>
        /// First Name
        /// </summary>
        string firstName;
        /// <summary>
        /// Last Name
        /// </summary>
        string lastName;
        /// <summary>
        /// characterName
        /// </summary>
        string characterName;
        /// <summary>
        /// Email Address
        /// </summary>
        string email;
        /// <summary>
        /// Password Reset Hash
        /// </summary>
        string passwordResetHash;
        /// <summary>
        /// Time when hash expires
        /// </summary>
        DateTime passwordHashExpiration;

        /// <summary>
        /// Facebook Oath Token
        /// </summary>
        string facebookToken;
        /// <summary>
        /// Google Oath Token
        /// </summary>
        string googleToken;
        /// <summary>
        /// Is this player enabled
        /// </summary>
        bool enabled;
        /// <summary>
        /// Player is a member of what Alliance -1 for none
        /// </summary>
        int allianceID;
        /// <summary>
        /// Marketing Department - Unique Click ID (FOR ALL KPI's)
        /// </summary>
        string sourceClickID;
        /// <summary>
        /// Marketing Department - Unique SUB 1
        /// </summary>
        string sourceSub1;
        /// <summary>
        /// Marketing Department - Unique SUB 2
        /// </summary>
        string sourceSub2;
        /// <summary>
        /// Marketing Department - Unique SUB 3
        /// </summary>
        string sourceSub3;
        /// <summary>
        /// Marketing Department - Unique SUB 4
        /// </summary>
        string sourceSub4;
        /// <summary>
        /// Marketing Department - Unique SUB 5
        /// </summary>
        string sourceSub5;

        /// <summary>
        /// DateTime - Timestamp When Player was Created
        /// </summary>
        DateTime createdAtTimestamp;

        int resourceQuartz;
        int resourceLithium;
        int resourceGold;
        int resourceSteel;
        int currency;

        bool firstLoginComplete;
        /* PROPERTIES */

        /// Get ID
        public int ID {
            get {
                return this.ID;
            }
        }
        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
        }
        public bool setFirstName(string name)
        {
            // Needs implemented
            return false;
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
        }
        bool setLastName(string name)
        {
            // Needs Implemented
            return false;
        }
        public string CharacterName
        {
            get
            {
                return this.characterName;
            }
        }
        public bool setCharacterName(string name)
        {
            
            return false;
        }
        public string Email
        {
            get
            {
                return this.email;
            }
        }
        public bool setEmail()
        {
            // Needs Implemented
            return false;
        }
        public string PasswordResetHash
        {
            get
            {
                return this.passwordResetHash;
            }
        }
        public void makeHash()
        {
            this.passwordResetHash = CommonTools.RandomString(64);

            this.passwordHashExpiration = DateTime.Now;
            passwordHashExpiration.AddDays(Settings.PASSWORD_HASH_EXPIRATION_DURATION_HOURS / 24);
            passwordHashExpiration.AddHours(passwordHashExpiration.Hour
                   % Settings.PASSWORD_HASH_EXPIRATION_DURATION_HOURS);

        }
        int ResourceQuartz {
            get{  return this.resourceQuartz; }
            set{  this.resourceQuartz = value;}
        }
        int ResourceLithium {
            get { return this.resourceLithium; }
            set { this.resourceLithium = value; }
        }
        int ResourceGold {
            get { return this.resourceGold; }
            set { this.resourceGold = value; }
        }
        int ResourceSteel
        {
            get { return this.resourceSteel; }
            set { this.resourceSteel = value; }
        }
        int Currency
        {
            get { return this.currency; }
            set { this.currency = value; }
        }











    }
}
