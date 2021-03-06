﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Production.Assembly
{
    public class MaterialsInstalled : CFXMessage
    {
        public MaterialsInstalled()
        {
            InstalledMaterials = new List<InstalledMaterial>();
        }

        public Guid TransactionId
        {
            get;
            set;
        }

        public List<InstalledMaterial> InstalledMaterials
        {
            get;
            set;
        }
    }
}
