﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CFX.Structures
{
    public class InstalledMaterial
    {
        public InstalledMaterial()
        {
            InstalledComponents = new List<InstalledComponent>();
        }

        public string UnitIdentifier
        {
            get;
            set;
        }

        public int? UnitPositionNumber
        {
            get;
            set;
        }

        public double QuantityInstalled
        {
            get;
            set;
        }

        public MaterialPackage Material
        {
            get;
            set;
        }

        public MaterialCarrierLocation CarrierLocation
        {
            get;
            set;
        }

        public List<InstalledComponent> InstalledComponents
        {
            get;
            set;
        }
    }
}
