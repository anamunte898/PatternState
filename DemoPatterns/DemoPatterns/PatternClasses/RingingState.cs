using DemoPatterns.Enums;

namespace DemoPatterns.PatternClasses
{
    public class RingingState:TelephoneState
    {
        public RingingState()
        {
            
        }

        public RingingState(Telephone telephone)
        {
            this.Telephone = telephone;
        }

        public override string StateName
        {
            get { return "Ringing"; }
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