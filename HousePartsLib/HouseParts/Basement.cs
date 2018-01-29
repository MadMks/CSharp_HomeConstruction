﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousePartsLib
{
    public class Basement : IPart
    {
        public bool IsBuilt { get; set; }

        public Basement()
        {
            IsBuilt = false;
        }

        public void Build()
        {
            IsBuilt = true;
        }

        public override string ToString()
        {
            return $" Построено: {IsBuilt}";
        }
    }
}
