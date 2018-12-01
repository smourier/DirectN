// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3d9types.h(2079,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERY_INPUT
    {
        public Guid QueryType;
        public IntPtr hChannel;
        public uint SequenceNumber;
    }
}
