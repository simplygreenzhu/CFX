﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Production
{
    public class UnitsArrived : CFXMessage
    {
        public UnitsArrived()
        {
            Units = new List<UnitPosition>();
        }

        public int UnitCount
        {
            get
            {
                return Units.Count;
            }
            private set
            {
            }
        }

        public List<UnitPosition> Units
        {
            get;
            set;
        }
    }
}
