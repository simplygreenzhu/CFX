﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CFX.Structures.SolderPastePrinting
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SMTCleanType
    {
        Normal,
        Deep,
        Quick
    }
}
