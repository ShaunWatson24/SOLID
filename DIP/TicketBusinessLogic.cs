using DIP.Interfaces;

public class TicketBusinessLogic
{
    ITicketDataAccess _ticketDataAccess;

    public TicketBusinessLogic()
    {
        _ticketDataAccess = DataAccessFactory.GetTicketData();
    }

    public string GetTicketDescription(string id)
    {
        return _ticketDataAccess.GetTicketDescription(id);
    }
}