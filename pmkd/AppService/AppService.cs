using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using pmkd.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Configuration;
using pmkd.AccountMail;
using Microsoft.AspNetCore.Authorization;
using pmkd.ModelService;
using pmkd.AppService;
using pmkd.Parameter;

namespace pmkd.AppService
{
    public class AppService 
    {
        SignalRChatContext _context = new SignalRChatContext();
        public AppService()
        {
        }

        public void AddUserConnection(string ConnectionId)
        {
            using (SignalRChatContext _context = new SignalRChatContext())
            {
                var userId = UserIdParameter.userId;
                _context.UserConnections.Add(new UserConnection
                {
                    ConnectionId = ConnectionId,
                    UserId = userId,
                });
                _context.SaveChanges();
            }
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
    }
}
