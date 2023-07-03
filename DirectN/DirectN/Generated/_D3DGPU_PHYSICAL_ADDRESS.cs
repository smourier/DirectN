// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(340,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DGPU_PHYSICAL_ADDRESS
    {
        public uint SegmentId;
        public uint Padding;
        public ulong SegmentOffset;
    }
}
