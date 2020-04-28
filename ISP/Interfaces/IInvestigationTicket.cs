namespace ISP
{
    public interface IInvestigationTicket : ITicket
    {
        string Findings { get; set; }

        string ReportFindings();
    }
}
