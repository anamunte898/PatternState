using DemoPatterns.PatternClasses;
using Microsoft.AspNet.SignalR;

namespace DemoPatterns.Hubs
{
    public class TelephonyHub : Hub
    {
        public void Call(Telephone telephone,string displayName)
        {
            telephone.Call();
            Clients.All.broadcastMessage(displayName, telephone);
        }

        public void Hold(Telephone telephone, string displayName)
        {

            telephone.HoldCall();
            Clients.All.broadcastMessage(displayName, telephone);
        }

        public void Connect(Telephone telephone, string displayName)
        {
            telephone.AcceptCall();
            Clients.All.broadcastMessage(displayName, telephone);
        }

        public void Disconnect(Telephone telephone, string displayName)
        {
            telephone.DenyCall();
            Clients.All.broadcastMessage(displayName, telephone);
        }
    }
}