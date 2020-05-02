using System;
using LSP;
using NUnit.Framework;

namespace SOLID.Tests
{
    public class LSPTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Can_withdraw_jira_ticket_that_is_in_progress()
        {
            // Arrange
            var ticket = new JiraTicket
            {
                Status = Status.InProgress
            };

            // Act
            ticket.Withdraw();

            // Assert
            Assert.AreEqual(Status.Withdrawn, ticket.Status);
        }

        [Test]
        public void Can_not_withdraw_bug_ticket_that_is_in_progress()
        {
            // Arrange
            JiraTicket ticket = new BugTicket()
            {
                Status = Status.InProgress
            };

            // Assert
            Assert.Throws<Exception>(() => ticket.Withdraw(), "This ticket is in progress");
        }

        [Test]
        public void Can_not_withdraw_spike_ticket_that_is_done()
        {
            // Arrange
            JiraTicket ticket = new SpikeTicket()
            {
                Status = Status.Done
            };

            // Assert
            Assert.Throws<Exception>(() => ticket.Withdraw(), "This ticket is already complete");
        }
    }
}