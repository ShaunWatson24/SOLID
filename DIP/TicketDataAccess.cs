using DIP.Interfaces;

public class TicketDataAccess : ITicketDataAccess
{
    public TicketDataAccess()
    {
    }

    public string GetTicketDescription(string id)
    {
        return "Ticket-12345 refers to...";
    }
}
