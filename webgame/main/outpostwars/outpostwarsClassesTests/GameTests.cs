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
        void setupTests()
        {
            game = new Game("Test");
        }
        [Test]
        void TestVersionConstructor()
        {
            Assert.AreEqual(game.version, "Test");
        }
        [Test]
        void TestDefaults()
        {
            Assert.False(game.databaseServerAvailable);
            Assert.False(game.loginServerAvailable);
        }
    };
}
