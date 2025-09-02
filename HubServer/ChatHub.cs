using Microsoft.AspNetCore.SignalR;

namespace HubServer
{
    public class ChatHub:Hub
    {
        public override Task OnConnectedAsync()
        {
            //Console.WriteLine("Client connected: " + Context.ConnectionId);
            Clients.Caller.SendAsync("ReceiveMassage", "Welcome to the chat room!");
            return base.OnConnectedAsync();
        }
    }
}
