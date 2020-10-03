﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace chatweb.Model
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(  string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
        }
    }
}