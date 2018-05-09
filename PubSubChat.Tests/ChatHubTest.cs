using System;
using System.Threading.Tasks;
using Xunit;
using PubSubChat.Hubs;

namespace PubSubChat.Tests
{
    public class ChatHubTest
    {
        private readonly ChatHub _chatHub;

        public ChatHubTest(){
            _chatHub = new ChatHub();
        }   

        [Fact]
        public void SendMessageTest()
        {
            
        }
    }
}
