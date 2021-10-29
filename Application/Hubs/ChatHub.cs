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
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using Application.Encrypt;
using Application.AccountMail;
using Microsoft.Extensions.Configuration;

namespace Application.Hubs
{
    public class ChatHub : Hub
    {
        SignalRChatContext _context = new SignalRChatContext();

        private IConfiguration _configuration;
        public ChatHub(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Task SendMessage(string sender, string user, string message)
        {
            return Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override Task OnConnectedAsync()
        {
            
            AspNetUser user = _context.AspNetUsers.Where(a => a.Id == UserIdParameter.userId).FirstOrDefault();
            user.Online = true;
            _context.AspNetUsers.Update(user);
            _context.SaveChanges();
            ListUser.CurrentConnection.Add(UserIdParameter.userId);
            Groups.AddToGroupAsync(Context.ConnectionId, UserIdParameter.userId);
            return base.OnConnectedAsync();
        }
        public override Task OnDisconnectedAsync(Exception exception)
        {
            AspNetUser user = _context.AspNetUsers.Where(a => a.Id == UserIdParameter.userId).FirstOrDefault();
            user.Online = false;
            _context.AspNetUsers.Update(user);
            _context.SaveChanges();
            ListUser.CurrentConnection.Remove(UserIdParameter.userId);
            return base.OnDisconnectedAsync(exception);
        }
        public List<string> GetAllActiveConnections()
        {
            return ListUser.CurrentConnection.ToList();
        }
        public Task SendMessageToGroup(string sender, string receiver, string message)
        {
            var SecurityStamp = _context.AspNetUsers.Where(a => a.Id == sender).Select(a => a.SecurityStamp).FirstOrDefault();
            var maxId1 = _context.Messages.Select(a => a.Id).FirstOrDefault();
            var maxId = maxId1 == 0 ? 1 : _context.Messages.Max(a => a.Id);
            Groups.AddToGroupAsync(Context.ConnectionId, receiver);
            Message _message = new Message();
            _message.FromUser = sender;
            _message.ToUser = receiver;
            _message.Message1 = EncryptString.Encrypt(message, SecurityStamp);
            _message.Date = DateTime.Now;
            Notification notification = new Notification();
            notification.id = maxId + 1;
            notification.FromUser = sender;
            notification.ToUser = receiver;
            notification.nguoiGui = _context.AspNetUsers.Where(a => a.Id == sender).Select(a => a.NormalizedUserName).FirstOrDefault();
            notification.Message1 = message;
            NotificationList.notifications.Add(notification);
            _context.Messages.Add(_message);
            _context.SaveChanges();
            var nguoiGui = _context.AspNetUsers.Where(a => a.Id == sender).Select(a => a.NormalizedUserName).FirstOrDefault();
            return Clients.Group(receiver).SendAsync("ReceiveMessage", sender,receiver, message,nguoiGui);
        }
        public string GetConnectionId() => Context.ConnectionId;

        public List<Notification> GetListNotification() {
            return  NotificationList.notifications.ToList();
        }

    }
}
