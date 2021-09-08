using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalRMVCDmz.Data.Entities;

namespace SignalRMVCDmz.Hubs
{
    public class CallCenterHub : Hub<ICallCenterHub>
    {
        public async Task NewCallReceived(Calls newCall)
        {
            await Clients.All.NewCallReceived(newCall);
        }
    }
}
