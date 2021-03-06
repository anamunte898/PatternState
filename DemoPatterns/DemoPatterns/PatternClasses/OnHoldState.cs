﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoPatterns.Enums;

namespace DemoPatterns.PatternClasses
{
    public class OnHoldState : TelephoneState
    {
        public OnHoldState()
        {
            
        }

        public OnHoldState(Telephone telephone)
        {
            Telephone = telephone;
        }

        public override string StateName
        {
            get { return "On Hold"; }
        }

        public override void AcceptCall()
        {
            Telephone.State = new ConnectedState(Telephone);
        }

        public override void DenyCall()
        {
            Telephone.State = new DisconnectedState(Telephone);
        }

        public override void HoldCall()
        {
            Telephone.State = this;
        }

        public override void Call()
        {
            Telephone.State = this;
        }
    }
}