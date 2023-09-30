using Microsoft.AspNetCore.SignalR;

namespace webapi.App
{
    public class ChatHub : Hub
    {
        public override async Task<string> OnConnectedAsync()
        {
            await Clients.All.SendAsync("ReceiveMessage", "is online");
            return Context.ConnectionId;
        }
    }
}
