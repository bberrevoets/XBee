﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XBee.Frames
{
     public class ZigBeeExplicitRXIndicator : XBeeFrame
    {
        public ZigBeeExplicitRXIndicator()
        {
            this.commandId = XBeeAPICommandId.RECEIVE_EXPLICIT_PACKET_RESPONSE;
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { };
        }
    }

}
