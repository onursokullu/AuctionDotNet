using AuctionCase.API.Services;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionCase.API.Hubs
{
    public class AuctionHub :Hub
    {
        private readonly AuctionService _service;
        public async Task GetCurrentTime()
        {
            await Clients.All.SendAsync("ReceiveAuction", _service.GetTime());
        }
    }
}
