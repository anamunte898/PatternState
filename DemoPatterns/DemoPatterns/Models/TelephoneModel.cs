using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DemoPatterns.PatternClasses;

namespace DemoPatterns.Models
{
    public class TelephoneModel
    {
        public TelephoneModel()
        {
            Telephone= new Telephone(new DisconnectedState());
        }
        public bool IsDispatch { get; set; }
        public Telephone Telephone { get; set; }
    }
}