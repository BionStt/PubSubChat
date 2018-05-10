using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace PubSubChat.Hubs
{
    public interface IPublisherHub : Hub
    {
        Task PublishMessage(string message);
    }
}