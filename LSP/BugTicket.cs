namespace LSP
{
    public class BugTicket : JiraTicket
    {
        public override bool CanWithdraw(out string reason)
        {
            if (Status != Status.InProgress) return base.CanWithdraw(out reason);

            reason = "This ticket is in progress";
            return false;
        }
    }
}
