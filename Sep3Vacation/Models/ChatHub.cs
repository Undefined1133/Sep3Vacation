using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Sep3Vacation.Models
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
            
        }

    }
}