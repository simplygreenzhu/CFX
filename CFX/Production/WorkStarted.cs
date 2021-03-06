﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using CFX.Structures;

namespace CFX.Production
{
    /// <summary>
    /// Indicates that work has begun on one or more production units at a particular work center.
    /// </summary>
    public class WorkStarted : CFXMessage
    {
        public WorkStarted()
        {
            TransactionID = Guid.NewGuid();
            Units = new List<UnitPosition>();
        }

        public Guid TransactionID
        {
            get;
            set;
        }

        public string Lane
        {
            get;
            set;
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
