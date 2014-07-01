using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoPatterns.Enums;

namespace DemoPatterns.PatternClasses
{
    public class DisconnectedState:TelephoneState
    {
       
        public DisconnectedState()
        {
            
        }

        public DisconnectedState(Telephone telephone)
        {
            Telephone = telephone;
        }

        public override void AcceptCall()
        {
            Telephone.State = this;
        }

        public override void DenyCall()
        {
            Telephone.State = this;
        }

        public override void HoldCall()
        {
            Telephone.State = this;
        }

        public override void Call()
        {
            Telephone.State = new RingingState(Telephone);
        }

        public override string StateName
        {
            get { return "Disconnected"; }
        }
    }
}