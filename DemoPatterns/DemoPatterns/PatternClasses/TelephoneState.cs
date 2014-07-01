using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using DemoPatterns.Enums;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace DemoPatterns.PatternClasses
{
    public abstract class TelephoneState
    {
        [ScriptIgnore]
        internal Telephone Telephone { get; set; }

        public abstract string StateName { get; }
        public abstract void AcceptCall();
        public abstract void DenyCall();
        public abstract void HoldCall();
        public abstract void Call();


       
    }
}