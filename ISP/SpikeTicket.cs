namespace ISP
{
    public class SpikeTicket : IInvestigationTicket
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public string Findings { get; set; }

        public string Assignee { get; set; }

        public void Assign(string assignee)
        {
            Assignee = assignee;
        }

        public string ReportFindings()
        {
            return "Bug is caused by...";
        }
    }
}
