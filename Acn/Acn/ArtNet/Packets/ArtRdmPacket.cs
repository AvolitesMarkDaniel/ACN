using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using Acn.ArtNet.IO;

namespace Acn.ArtNet.Packets
{
    internal class ArtRdmPacket:ArtNetPacket
    {
        public ArtRdmPacket()
            : base(ArtNetOpCodes.Rdm)
        {
            RdmVersion = 1;
            SubStartCode = 1;
        }

        public ArtRdmPacket(ArtNetRecieveData data)
            : base(data)
        {
            
        }

        #region Packet Properties

        public byte RdmVersion { get; set; }

        public byte Net { get; set; }

        public byte Command { get; set; }

        public byte Address { get; set; }

        public byte SubStartCode { get; set; }

        public byte[] RdmData { get; set; }
	
	
        #endregion

        public override void ReadData(System.IO.BinaryReader data)
        {
            base.ReadData(data);

            RdmVersion = data.ReadByte();
            data.BaseStream.Seek(8, System.IO.SeekOrigin.Current);
            Net = data.ReadByte();
            Command = data.ReadByte();
            Address = data.ReadByte();
            SubStartCode = data.ReadByte();
            RdmData = data.ReadBytes((int) (data.BaseStream.Length - data.BaseStream.Position));
        }

        public override void WriteData(System.IO.BinaryWriter data)
        {
            base.WriteData(data);

            data.Write(RdmVersion);
            data.Write(new byte[8]);
            data.Write(Net);
            data.Write(Command);
            data.Write(Address);
            data.Write(SubStartCode);
            data.Write(RdmData);
        }
	

    }
}
