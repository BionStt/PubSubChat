using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace PubSubChat.Hubs
{
    [Authorize]
    public class PublisherHub : Hub
    {
        public async Task PublishMessage(string message)
        {
            await Clients.All.SendAsync("SendMessage", "System", message);
        }
    }
}