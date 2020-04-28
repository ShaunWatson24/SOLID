using DIP.Interfaces;

public class DataAccessFactory
{
    public static ITicketDataAccess GetTicketData()
    {
        return new TicketDataAccess();
    }
}
