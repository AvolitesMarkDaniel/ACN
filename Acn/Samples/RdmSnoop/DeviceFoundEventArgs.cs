﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Acn.Rdm;
using System.Net;
using Acn.Sockets;

namespace RdmSnoop
{
    public class DeviceFoundEventArgs:EventArgs
    {

        public DeviceFoundEventArgs(UId id, RdmAddress address)
        {
            this.id = id;
            this.ipAddress = address;
        }

        private UId id = UId.Empty;

        public UId Id
        {
            get { return id; }
            set { id = value; }
        }

        private RdmAddress ipAddress;

        public RdmAddress IpAddress
        {
            get { return ipAddress; }
            set { ipAddress = value; }
        }

    }
}
