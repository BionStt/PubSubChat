using System;
using System.Threading.Tasks;
using Xunit;
using PubSubChat.Hubs;

namespace PubSubChat.Tests
{
    public class PublisherHubTest
    {
        private readonly PublisherHub _publisherHub;

        public PublisherHubTest(){
            _publisherHub = new PublisherHub();
        }   

        [Fact]
        public void SendMessageTest()
        {
            Assert.ThrowsAsync<Exception>(async () => await _publisherHub.PublishMessage("Hello from the machine!"));
        }
    }
}
