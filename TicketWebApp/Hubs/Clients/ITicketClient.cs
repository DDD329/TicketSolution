namespace TicketWebApp.Hubs.Clients
{
    public interface ITicketClient
    {
        Task ReceiveCreatedTicketMessage(CreatedTicketMessage message);
    }
}
