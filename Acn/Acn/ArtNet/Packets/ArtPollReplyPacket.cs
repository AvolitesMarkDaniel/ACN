using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Acn.ArtNet.IO;
using Acn.ArtNet.Sockets;

namespace Acn.ArtNet.Packets
{
    [Flags]
    public enum PollReplyStatus
    {
        None = 0,
        UBEA = 1,
        RdmCapable = 2,
        ROMBoot = 4
    }

    public class ArtPollReplyPacket:ArtNetPacket
    {
        public ArtPollReplyPacket()
            : base(ArtNetOpCodes.PollReply)
        {
        }

        public ArtPollReplyPacket(ArtNetRecieveData data)
            : base(data)
        {
            
        }

        #region Packet Properties

        private byte[] ipAddress=new byte[4];

        public byte[] IpAddress
        {
            get { return ipAddress; }
            set 
            {
                if (value.Length != 4)
                    throw new ArgumentException("The IP address must be an array of 4 bytes.");

                ipAddress = value; 
            }
        }

        private short port= ArtNetSocket.Port;

        public short Port
        {
            get { return port; }
            set { port = value; }
        }

        private short firmwareVersion = 0;

        public short FirmwareVersion
        {
            get { return firmwareVersion; }
            set { firmwareVersion = value; }
        }



        private short subSwitch = 0;

        public short SubSwitch
        {
            get { return subSwitch; }
            set { subSwitch = value; }
        }

        private short oem = 0xff;

        public short Oem
        {
            get { return oem; }
            set { oem = value; }
        }

        private byte ubeaVersion= 0;

        public byte UbeaVersion
        {
            get { return ubeaVersion; }
            set { ubeaVersion = value; }
        }

        private PollReplyStatus status = 0;

        public PollReplyStatus Status
        {
            get { return status; }
            set { status = value; }
        }

        private string estaCode= string.Empty;

        public string EstaCode
        {
            get { return estaCode; }
            set { estaCode = value; }
        }

        private string shortName = string.Empty;

        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }

        private string longName = string.Empty;

        public string LongName
        {
            get { return longName; }
            set { longName = value; }
        }

        private string nodeReport= string.Empty;

        public string NodeReport
        {
            get { return nodeReport; }
            set { nodeReport = value; }
        }

        private short portCount=0;

        public short PortCount
        {
            get { return portCount; }
            set { portCount = value; }
        }

        private byte[] portTypes= new byte[4];

        public byte[] PortTypes
        {
            get { return portTypes; }
            set 
            {
                if (value.Length != 4)
                    throw new ArgumentException("The port types must be an array of 4 bytes.");

                portTypes = value; 
            }
        }

        private byte[] goodInput = new byte[4];

        public byte[] GoodInput
        {
            get { return goodInput; }
            set 
            {
                if (value.Length != 4)
                    throw new ArgumentException("The good input must be an array of 4 bytes.");

                goodInput = value; 
            }
        }

        private byte[] goodOutput = new byte[4];

        public byte[] GoodOutput
        {
            get { return goodOutput; }
            set {
                if (value.Length != 4)
                    throw new ArgumentException("The good output must be an array of 4 bytes.");

                goodOutput = value; 
            }
        }

        private byte[] swIn = new byte[4];

        public byte[] SwIn
        {
            get { return swIn; }
            set { swIn = value; }
        }

        private byte[] swOut = new byte[4];

        public byte[] SwOut
        {
            get { return swOut; }
            set { swOut = value; }
        }

        private byte swVideo=0;

        public byte SwVideo
        {
            get { return swVideo; }
            set { swVideo = value; }
        }

        private byte swMacro=0;

        public byte SwMacro
        {
            get { return swMacro; }
            set { swMacro = value; }
        }

        private byte swRemote=0;

        public byte SwRemote
        {
            get { return swRemote; }
            set { swRemote = value; }
        }

        private byte style=0;

        public byte Style
        {
            get { return style; }
            set { style = value; }
        }

        private byte[] macAddress= new byte[6];

        public byte[] MacAddress
        {
            get { return macAddress; }
            set 
            {
                if (value.Length != 6) 
                    throw new ArgumentException("The mac address must be an array of 6 bytes.");
                
                macAddress = value; 
            }
        }

        private byte[] bindIpAddress = new byte[4];

        public byte[] BindIpAddress
        {
            get { return bindIpAddress; }
            set {
                if (value.Length != 4)
                    throw new ArgumentException("The bind IP address must be an array of 4 bytes.");

                bindIpAddress = value; }
        }

        private byte bindIndex= 0;

	    public byte BindIndex
	    {
		    get { return bindIndex;}
		    set { bindIndex = value;}
	    }

        private byte status2 = 0;

        public byte Status2
        {
            get { return status2; }
            set { status2 = value; }
        }
	
	
        #endregion

        public override void ReadData(ArtNetBinaryReader data)
        {
            Protocol = data.ReadNetworkString(8);
            OpCode = data.ReadInt16();
            IpAddress = data.ReadBytes(4);
            Port = data.ReadInt16();
            FirmwareVersion = data.ReadNetwork16();
            SubSwitch = data.ReadNetwork16();
            Oem = data.ReadNetwork16();
            UbeaVersion = data.ReadByte();
            Status = (PollReplyStatus)data.ReadByte();
            EstaCode = data.ReadNetworkString(2);
            ShortName = data.ReadNetworkString(18);
            LongName = data.ReadNetworkString(64);
            NodeReport = data.ReadNetworkString(64);
            PortCount = data.ReadNetwork16();
            PortTypes = data.ReadBytes(4);
            GoodInput = data.ReadBytes(4);
            GoodOutput = data.ReadBytes(4);
            SwIn = data.ReadBytes(4);
            SwOut = data.ReadBytes(4);
            SwVideo = data.ReadByte();
            SwMacro = data.ReadByte();
            SwRemote = data.ReadByte();
            data.ReadBytes(3);
            Style = data.ReadByte();
            MacAddress = data.ReadBytes(6);
            BindIpAddress = data.ReadBytes(4);
            BindIndex = data.ReadByte();
            Status2 = data.ReadByte();
        }

        public override void WriteData(ArtNetBinaryWriter data)
        {
            data.WriteNetwork(Protocol,8);
            data.Write(OpCode);
            data.Write(IpAddress);
            data.Write(Port);
            data.WriteNetwork(FirmwareVersion);
            data.WriteNetwork(SubSwitch);
            data.WriteNetwork(Oem);
            data.Write(UbeaVersion);
            data.Write((byte) Status);
            data.WriteNetwork(EstaCode,2);
            data.WriteNetwork(ShortName,18);
            data.WriteNetwork(LongName,64);
            data.WriteNetwork(NodeReport,64);
            data.WriteNetwork(PortCount);
            data.Write(PortTypes);
            data.Write(GoodInput);
            data.Write(GoodOutput);
            data.Write(SwIn);
            data.Write(SwOut);
            data.Write(SwVideo);
            data.Write(SwMacro);
            data.Write(SwRemote);
            data.Write(new byte[3]);
            data.Write(Style);
            data.Write(MacAddress);
            data.Write(BindIpAddress);
            data.Write(BindIndex);
            data.Write(Status2);
            data.Write(new byte[208]);
        }
	

    }
}
