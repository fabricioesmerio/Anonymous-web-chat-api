using Microsoft.AspNetCore.SignalR;

namespace webapi.App
{
    public sealed class ChatHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveMessage", "is online");
            Console.WriteLine($"Connectionid :: {Context.ConnectionId}");
        }
    }
}
