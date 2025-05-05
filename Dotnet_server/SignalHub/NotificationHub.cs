using Microsoft.AspNetCore.SignalR;

namespace Dotnet_server.SignalHub;

public class NotificationHub : Hub
{
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
