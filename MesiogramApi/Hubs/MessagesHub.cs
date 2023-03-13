using Microsoft.AspNetCore.SignalR;

namespace MesiogramApi.Hubs;

public class MessagesHub : Hub// royhattan otkan clentlarni ozida saqlaydi list bilan 
{
    public async Task SendMessage(string message, string username)
    {
        await Clients.All.SendAsync("GetMessage",message, username);
    }
}
