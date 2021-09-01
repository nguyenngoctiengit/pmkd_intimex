using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using pmkd.ModelChat;
using pmkd.Models;
using System.Web;
using pmkd.ModelService;
using Microsoft.AspNetCore.Http;

namespace pmkd.AppService
{
    public class AppService
    {
        SignalRChatContext _context = new SignalRChatContext();
        public AppService()
        {
        }
        public bool login(LoginData loginData,out string userId)
        {
            userId = "";
            var currentUser = _context.AspNetUsers.FirstOrDefault(a => a.UserName == loginData.Username && a.Status == true);
            if (currentUser != null)
            {
                if (BCrypt.Net.BCrypt.Verify(loginData.Password, currentUser.PasswordHash))
                {
                    userId = currentUser.Id;
                    return true;
                }
            }
            return false;
        }
        internal void RemoveAllUserConnections(string userId)
        {
            var current = _context.UserConnections.Where(x => x.UserId == userId);
            _context.UserConnections.RemoveRange(current);
            _context.SaveChanges();
        }
        internal int AddUserConnection(Guid ConnectionId)
        {
            var userId = HttpContext.s
            _Context.UserConnections.Add(new UserConnection
            {
                ConnectionId = ConnectionId,
                UserId = userId,
            });
            _Context.SaveChanges();
            return userId;
        }
    }
}
