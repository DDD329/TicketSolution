namespace TicketWebApp
{
    /// <summary>
    /// Сообщение для создания нового тикета
    /// </summary>
    public class NewTicketMessage
    {
        /// <summary>
        /// Тема тикета
        /// </summary>
        public string Subject { get; init; } = "";

        /// <summary>
        /// Описание тикета
        /// </summary>
        public string Description { get; init; } = "";

        /// <summary>
        /// Дата создания тикета
        /// </summary>
        public DateTime CreatedDate { get; init; }
    }
}