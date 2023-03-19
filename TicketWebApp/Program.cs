using Persistence;
using TicketWebApp.DataTransferObjects;
using TicketWebApp.Hubs;

var builder = WebApplication.CreateBuilder(args);

// подключаем сервисы SignalR
builder.Services.AddSignalR();

builder.Services.AddCors(options =>
{
    options.AddPolicy("ClientPermission", policy =>
    {
        policy.AllowAnyHeader()
            .AllowAnyMethod()
            .WithOrigins("http://localhost:3000")
            .AllowCredentials();
    });
});

var app = builder.Build();

app.UseCors("ClientPermission");

//app.UseRouting();

app.MapGet("/", () => "Hello World!");

// TicketHub будет обрабатывать запросы по пути '/hubs/ticket'
app.MapHub<TicketHub>("/hubs/ticket");

app.MapGet("/api/tickets", () => {
    using (var db = new DomainContext())
    {
        return db
            .Tickets
            .ToArray()
            .Select(t => new TicketDto(t));
    }
});

app.MapGet("/api/tickets/{id}", (int id) => {
    using (var db = new DomainContext())
    {
        var ticket = db.Tickets.Single(t => t.Id == id);
        return new TicketDto(ticket);
    }
});

app.Run();
