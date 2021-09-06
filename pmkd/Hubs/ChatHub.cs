using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using pmkd.AppService;
using pmkd.Parameter;
using pmkd.Models;

namespace pmkd.Hubs
{
    public class ChatHub : Hub
    {
        SignalRChatContext _context = new SignalRChatContext();
        public Task SendMessage(string sender, string user,string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override Task OnConnectedAsync()
        {
            new AppService.AppService().AddUserConnection(Context.ConnectionId);
            Groups.AddToGroupAsync(Context.ConnectionId, UserIdParameter.userId);
            return base.OnConnectedAsync();
        }
        public Task SendMessageToGroup(string sender, string receiver, string message)
        {
            var nguoiGui = _context.AspNetUsers.Where(a => a.Id == sender).Select(a => a.NormalizedUserName).FirstOrDefault();
            return Clients.Group(receiver).SendAsync("ReceiveMessage", nguoiGui, message);
        }
        public string GetConnectionId() => Context.ConnectionId;
    }
}
