using AuctionCase.API.Hubs;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuctionCase.API.Services
{
    public class AuctionService
    {
        private readonly IHubContext<AuctionHub> _hubContext;
        public AuctionService(IHubContext<AuctionHub> hubContext)
        {
            _hubContext = hubContext;
        }
        public async Task GetAll()
        {
            await _hubContext.Clients.All.SendAsync("ReceiveTime", GetTime());
        }
        public DateTime GetTime()
        {
            var time = DateTime.Now;
            return time;
        }
    }
}
