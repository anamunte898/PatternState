using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace DemoPatterns.Enums
{
    public enum StatusEnum
    {
        [Description("Call active")]
        Active,
        [Description("Call is disconnected")]
        Disconected,
        [Description("Phone is ringing")]
        Ringing,
        [Description("Call is on hold")]
        OnHold,
    }
}