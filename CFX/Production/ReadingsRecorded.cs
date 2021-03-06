﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Production
{
    public class ReadingsRecorded : CFXMessage
    {
        public ReadingsRecorded()
        {
            Readings = new List<Reading>();
        }

        /// <summary>
        /// If the readings related to this message are associated with a work transaction, this property
        /// contains the Id of the transaction.
        /// </summary>
        public Guid? TransactionId
        {
            get;
            set;
        }

        /// <summary>
        /// A collection of readings to be recorded.
        /// </summary>
        public List<Reading> Readings
        {
            get;
            set;
        }
    }
}
