using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HomeConstruction
{
    [Serializable]
    public class NoRelevantEmployees : Exception
    {
        public NoRelevantEmployees() 
            : this("Для определенных частей дома нет соответствующих работников.") { }
        public NoRelevantEmployees(string message) : base(message) { }
        public NoRelevantEmployees(string message, Exception inner) : base(message, inner) { }
        protected NoRelevantEmployees(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}