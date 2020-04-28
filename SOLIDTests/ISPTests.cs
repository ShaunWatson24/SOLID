using System;
using ISP;
using NUnit.Framework;

namespace SOLID.Tests
{
    public class ISPTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Can_assign_bug_ticket()
        {
            // Arrange
            ITaskTicket bug = new BugTicket
            {
                Assignee = "Dan",
                Withdrawn = false,
                Id = "SAS-12345",
                StoryPoints = 3
            };

            // Act
            bug.Assign("Shaun");

            // Assert
            Assert.AreEqual(bug.Assignee, "Shaun");
        }

        [Test]
        public void Can_withdraw_bug_ticket()
        {
            // Arrange
            ITaskTicket bug = new BugTicket
            {
                Assignee = "Dan",
                Withdrawn = false,
                Id = "SAS-12345",
                StoryPoints = 3
            };

            // Act
            bug.Withdraw();

            // Assert
            Assert.AreEqual(bug.Withdrawn, true);
        }

        [Test]
        public void Can_report_findings_via_spike_ticket()
        {
            // Arrange
            IInvestigationTicket spike = new SpikeTicket
            {
                Assignee = "Dan",
                Id = "SAS-12345"
            };

            // Act
            var findings = spike.ReportFindings();

            // Assert
            Assert.AreEqual(findings, "Bug is caused by...");
        }
    }
}