using System;
using System.Collections.Generic;
using System.Text;

namespace Acn.ArtNet.IO
{
    public class ArtNetRecieveData
    {
        public byte[] buffer = new byte[1000];
        public int bufferSize = 1000;
        public int DataLength = 0;

        public bool Valid
        {
            get { return DataLength > 12; }
        }

        public int OpCode
        {
            get
            {
                return buffer[10] + (buffer[9] << 8);
            }
        }
	
    }
}