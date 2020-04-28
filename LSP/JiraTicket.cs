using System;

namespace LSP
{
    public class JiraTicket
    {
        public Status Status { get; set; }

        public virtual bool CanWithdraw(out string reason)
        {
            reason = null;
            return true;
        }

        public void Withdraw()
        {
            if (!CanWithdraw(out var reason))
                throw new Exception(reason);

            Status = Status.Withdrawn;
        }
    }
}
