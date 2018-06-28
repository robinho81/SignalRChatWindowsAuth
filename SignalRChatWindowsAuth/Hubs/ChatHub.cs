using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalRChatWindowsAuth.Hubs
{
  public class ChatHub : Hub
  {
    public async Task SendMessage(string user, string message)
    {
      await Clients.All.SendAsync("ReceiveMessage", user, message);
    }

    public async Task SendToMe(string user, string message)
    {
      // Attempting to send a message to a specific user 
      // See: https://docs.microsoft.com/en-us/aspnet/core/signalr/groups?view=aspnetcore-2.1
      await Clients.Users(user).SendAsync("ReceiveMyMessage", message);
    }
  }
}