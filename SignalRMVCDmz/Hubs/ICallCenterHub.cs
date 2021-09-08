using System.Threading.Tasks;
using SignalRMVCDmz.Data.Entities;

namespace SignalRMVCDmz.Hubs
{
    public interface ICallCenterHub
    {
        Task NewCallReceived(Calls newCall);
    }
}