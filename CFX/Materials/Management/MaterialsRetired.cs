﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Materials.Management
{
    public class MaterialsRetired : CFXMessage
    {
        public MaterialsRetired()
        {
            Materials = new List<MaterialPackage>();
        }

        public List<MaterialPackage> Materials
        {
            get;
            set;
        }
    }
}
