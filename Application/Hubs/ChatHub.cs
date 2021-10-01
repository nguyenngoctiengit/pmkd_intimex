using Application.AppServices;
using Application.Parameter;
using Data.Models.SignalR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Public_class;

namespace Application.Hubs
{
    public class ChatHub : Hub
    {
        SignalRChatContext _context = new SignalRChatContext();
        public Task SendMessage(string sender, string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override Task OnConnectedAsync()
        {
            ListUser.CurrentConnection.Add(UserIdParameter.userId);
            Groups.AddToGroupAsync(Context.ConnectionId, UserIdParameter.userId);
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            ListUser.CurrentConnection.Remove(UserIdParameter.userId);
            return base.OnDisconnectedAsync(exception);
        }
        public List<string> GetAllActiveConnections()
        {
            return ListUser.CurrentConnection.ToList();
        }
        public Task SendMessageToGroup(string sender, string receiver, string message)
        {
            Groups.AddToGroupAsync(Context.ConnectionId, receiver);
            Message _message = new Message();
            _message.FromUser = sender;
            _message.ToUser = receiver;
            _message.Message1 = message;
            _message.Date = DateTime.Now;
            /*int maxId = _context.Messages.Max(a => a.Id);
            _message.Id = maxId + 1;*/
            _context.Messages.Add(_message);
            _context.SaveChanges();
            var nguoiGui = _context.AspNetUsers.Where(a => a.Id == sender).Select(a => a.NormalizedUserName).FirstOrDefault();
            return Clients.Group(receiver).SendAsync("ReceiveMessage", sender,receiver, message);
        }
        public string GetConnectionId() => Context.ConnectionId;
    }
}
