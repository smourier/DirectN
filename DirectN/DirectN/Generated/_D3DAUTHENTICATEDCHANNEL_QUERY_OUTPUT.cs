// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3d9types.h(2086,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DAUTHENTICATEDCHANNEL_QUERY_OUTPUT
    {
        public _D3D_OMAC omac;
        public Guid QueryType;
        public IntPtr hChannel;
        public uint SequenceNumber;
        public HRESULT ReturnCode;
    }
}
