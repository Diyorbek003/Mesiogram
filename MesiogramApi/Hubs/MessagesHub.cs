using MesiogramApi.Services;
using Microsoft.AspNetCore.SignalR;

namespace MesiogramApi.Hubs;

public class MessagesHub : Hub// royhattan otkan clentlarni ozida saqlaydi list bilan 
{
    private readonly HubclientsService hubclientsService;

    public MessagesHub(HubclientsService hubclientsService)
    {
        this.hubclientsService = hubclientsService;
    }



    public override Task OnConnectedAsync()
    {
        hubclientsService.Clients.Add(Context.ConnectionId);
        return Task.CompletedTask;
    }

    public async Task SendMessage(string message, string username)
    {
        await Clients.All.SendAsync("GetMessage",message, username);
    }
}
