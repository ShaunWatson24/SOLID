namespace LSP
{
    public class SpikeTicket : JiraTicket
    {
        public override bool CanWithdraw(out string reason)
        {
            if (Status != Status.Done) return base.CanWithdraw(out reason);

            reason = "This ticket is already complete";
            return false;
        }
    }
}
