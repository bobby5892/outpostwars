using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using outpostWarsClasses;
using outpostwarsdb;
namespace outpostwarsClassesTests
{
    [TestFixture]
    public class CreateTests
    {
        [SetUp]
        public void setupAllTests()
        {

        }
        [Test]
        public void TestCreateSector()
        {
            Create create = new Create();
            Sector sector = new Sector();
            sector.name = "test";
            sector.allowsNewPlayers = true;
            sector.allowPayToWinStore = true;
            sector.visibleToPlayers = true;
            sector.enabled = true;
          
            if (create.CreateSector(sector))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }

        }
        [Test]
        public void TestCreatePlayer()
        {
            /// This will not be a player that can LOGIN due to missing proper CLSID in the ASPNET
            /// 
            Create create = new Create();
            Player newPlayer = new Player();
            newPlayer.CLSID = "TESTTESTTESTTESTTESTTESTTEST";
            newPlayer.email = "test@example.com";

            // Add to Test Sector
            newPlayer.sectorID = 1;
           
            if(create.CreatePlayer(newPlayer))
            {
               // TRUE
            }
            else
            {
                Assert.Fail();
            }
        }

    }
}
