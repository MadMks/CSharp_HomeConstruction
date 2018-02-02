using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HomeConstruction
{

    [Serializable]
    public class TeamDoesNotHaveATeamLeader : Exception
    {
        public TeamDoesNotHaveATeamLeader() 
            : this(" В бригаде нет бригадира.") { }
        public TeamDoesNotHaveATeamLeader(string message) : base(message) { }
        public TeamDoesNotHaveATeamLeader(string message, Exception inner) : base(message, inner) { }
        protected TeamDoesNotHaveATeamLeader(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
