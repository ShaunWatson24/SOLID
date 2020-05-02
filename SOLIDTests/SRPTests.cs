using NUnit.Framework;
using SRP;

namespace SOLID.Tests
{
    public class SRPTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Can_attack_target()
        {
            // Arrange
            Soldier player = new Soldier { Health = 100 };
            Soldier enemy = new Soldier { Health = 100 };

            // Act
            player.Attack(enemy);

            // Assert
            Assert.AreEqual(0, enemy.Health);
        }
    }
}