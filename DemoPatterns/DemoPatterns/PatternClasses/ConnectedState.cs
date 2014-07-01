using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoPatterns.Enums;

namespace DemoPatterns.PatternClasses
{
    public class ConnectedState:TelephoneState
    {
        public ConnectedState()
        {
        }

        public ConnectedState(Telephone telephone)
        {
            Telephone = telephone;
        }

        public override string StateName
        {
            get { return "Connected"; }
        }

        public override void AcceptCall()
        {
            Telephone.State = this;
        }

        public override void DenyCall()
        {
            Telephone.State = new DisconnectedState(Telephone);
        }

        public override void HoldCall()
        {
            Telephone.State = new OnHoldState(Telephone);
        }

        public override void Call()
        {
            Telephone.State = this;
        }
    }
}