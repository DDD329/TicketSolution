using Domain;

namespace TicketWebApp.DataTransferObjects
{
    /// <summary>
    /// Объект переноса данных для сущности Тикет
    /// </summary>
    public class TicketDto
    {
        /// <summary>
        /// Идентификатор тикета
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Тема тикета
        /// </summary>
        public string Subject { get; private set; }

        /// <summary>
        /// Описание тикета
        /// </summary>
        public string Description { get; private set; }

        /// <summary>
        /// Дата создания тикета
        /// </summary>
        public DateTime CreatedDate { get; private set; }

        /// <summary>
        /// Конструктор тикета
        /// </summary>
        /// <param name="subject">Тема тикета</param>
        /// <param name="description">Описание тикета</param>
        /// <param name="createdDate">Дата создания тикета</param>
        public TicketDto(Ticket ticket)
        {
            Id = ticket.Id;
            Subject = ticket.Subject;
            Description = ticket.Description;
            CreatedDate = ticket.CreatedDate;
        }
    }
}
