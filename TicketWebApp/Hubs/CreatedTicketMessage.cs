namespace TicketWebApp
{
    /// <summary>
    /// Сообщение о создании нового тикета
    /// </summary>
    public class CreatedTicketMessage
    {
        /// <summary>
        /// Идентификатор нового тикета
        /// </summary>
        public int TicketId { get; private set; }

        public CreatedTicketMessage(int ticketId)
        {
            TicketId = ticketId;
        }
    }
}
