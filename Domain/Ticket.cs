namespace Domain
{
    /// <summary>
    /// Тикет
    /// </summary>
    public class Ticket
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
        public Ticket(string subject, string description, DateTime createdDate)
        {
            Subject = subject;
            Description = description;
            CreatedDate = createdDate;
        }
    }
}