namespace ISP
{
    public interface ITicket
    {
        string Id { get; set; }

        string Description { get; set; }

        string Assignee { get; set; }

        void Assign(string assignee);
    }
}
