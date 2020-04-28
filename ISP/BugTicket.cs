namespace ISP
{
    public class BugTicket : ITaskTicket
    {
        public string Id { get; set; }

        public string Description { get; set; }

        public int StoryPoints { get; set; }

        public Status Status { get; set; }

        public string Assignee { get; set; }

        public bool Withdrawn { get; set; }

        public void Assign(string assignee)
        {
            Assignee = assignee;
        }

        public void Withdraw()
        {
            Withdrawn = true;
        }
    }
}
