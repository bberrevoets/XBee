﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XBee.Frames
{
    public class ATCommandResponse : XBeeFrame
    {
        public ATCommandResponse()
        {
            this.commandId = XBeeAPICommandId.AT_RESPONSE;
        }

        public override byte[] ToByteArray()
        {
            return new byte[] { };
        }
    }
}
