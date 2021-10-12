﻿using Application.Parameter;
using Data.Models.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.AppServices
{
    public class AppService
    {
        SignalRChatContext _context = new SignalRChatContext();
        public AppService()
        {
        }

        public bool login(AspNetUser aspNetUser, out string userId)
        {
            userId = "";
            var currentUser = _context.AspNetUsers.FirstOrDefault(a => a.UserName == aspNetUser.UserName && a.Status == true);
            if (currentUser != null)
            {
                if (BCrypt.Net.BCrypt.Verify(aspNetUser.PasswordHash, currentUser.PasswordHash))
                {
                    userId = currentUser.Id;
                    return true;
                }
            }
            return false;
        }
    }
}