using DIP.Interfaces;
using NUnit.Framework;

namespace SOLID.Tests
{
    public class DIPTests
    {
        ITicketDataAccess _ticketDataAccess;

        [SetUp]
        public void Setup()
        {
            _ticketDataAccess = DataAccessFactory.GetTicketData();
        }

        [Test]
        public void Can_get_ticket_description()
        {
            // Arrange
            var id = "Ticket-12345";

            // Act
            var description = _ticketDataAccess.GetTicketDescription(id);

            // Assert
            Assert.AreEqual(description, "Ticket-12345 refers to...");

        }
    }
}