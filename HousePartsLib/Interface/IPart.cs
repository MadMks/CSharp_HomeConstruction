using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePartsLib
{
    public interface IPart
    {
        int NumberOfParts { get; set; }
        int NumberBuiltParts { get; set; }
        bool IsBuilt { get; set; }
        void Build();
    }
}