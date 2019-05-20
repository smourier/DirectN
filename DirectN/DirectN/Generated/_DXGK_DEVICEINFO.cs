// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1191,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DEVICEINFO
    {
        public uint DmaBufferSize;
        public uint DmaBufferSegmentSet;
        public uint DmaBufferPrivateDataSize;
        public uint AllocationListSize;
        public uint PatchLocationListSize;
        public _DXGK_DEVICEINFOFLAGS Flags;
    }
}
