using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using DemoPatterns.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DemoPatterns.PatternClasses
{
    public class Telephone
    {
        public Telephone()
        {
        }

        public Telephone(TelephoneState state)
        {
            this.State = state;
            state.Telephone = this;
        }

        public TelephoneState State { get; internal set; }
        public  void AcceptCall()
        {
            State.AcceptCall();
        }

        public void DenyCall()
        {
            State.DenyCall();
        }

        public  void HoldCall()
        {
            State.HoldCall();
        }

        public  void Call()
        {
            State.Call();
        }
        public string Status
        {
            get
            {
                return State == null ? string.Empty : State.ToString();
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {   
                    State = (TelephoneState)Activator.CreateInstance(Type.GetType(value));
                    State.Telephone = this;
                }
            }
        }

    }
}