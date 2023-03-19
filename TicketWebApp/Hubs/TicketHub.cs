using Domain;
using Microsoft.AspNetCore.SignalR;
using Persistence;
using TicketWebApp.Hubs.Clients;

namespace TicketWebApp.Hubs
{
    public class TicketHub : Hub<ITicketClient>
    {
        /// <summary>
        /// Обрабатывает сообщение о создании нового тикета
        /// </summary>
        /// <param name="message">Сообщение для создания нового тикета</param>
        /// <returns></returns>
        public async Task SendNewTicketMessage(NewTicketMessage message)
        {
            Ticket newTicket;

            using (var db = new DomainContext())
            {
                newTicket = new Ticket(message.Subject, message.Description, message.CreatedDate);

                db.Tickets.Add(newTicket);

                db.SaveChanges();
            }

            var createdTicketMessage = new CreatedTicketMessage(newTicket.Id);

            await Clients.All.ReceiveCreatedTicketMessage(createdTicketMessage);
        }
    }
}