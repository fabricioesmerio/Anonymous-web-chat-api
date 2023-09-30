
using webapi.App;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<ChatHub>("/chat");
app.MapGet("/", () => "Estou online");

app.Run();
