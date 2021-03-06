﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;
using CFX.Structures.SolderPastePrinting;

namespace CFX.ResourcePerformance.SolderPastePrinting
{
    public class StencilChanged : CFXMessage
    {
        public SMTStencil OldStencil
        {
            get;
            set;
        }

        public SMTStencil NewStencil
        {
            get;
            set;
        }
    }
}
