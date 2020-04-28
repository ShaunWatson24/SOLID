namespace ISP
{
    public interface ITaskTicket : ITicket
    {
        int StoryPoints { get; set; }

        Status Status { get; set; }

        bool Withdrawn { get; set; }

        void Withdraw();
    }
}
