using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using outpostWarsClasses;
namespace outpostwarsClassesTests
{
    
    [TestFixture]
    public class GameTests
    {
        Game game;
        
        [SetUp]
        public void SetUpAllTests()
        {

        }
        [Test]
        public void TestVersionConstructor()
        {
            game = new Game("Test");
            Assert.AreEqual(game.version, "Test");
        }

        [Test]
        public void TestDefaults()
        {
            game = new Game("Test");
            Assert.False(game.databaseServerAvailable);
            Assert.False(game.loginServerAvailable);
        }
    };
}
