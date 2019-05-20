// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1293,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_CONTEXTINFO
    {
        public uint DmaBufferSize;
        public uint DmaBufferSegmentSet;
        public uint DmaBufferPrivateDataSize;
        public uint AllocationListSize;
        public uint PatchLocationListSize;
        public uint Reserved;
        public _DXGK_CONTEXTINFO_CAPS Caps;
        public uint PagingCompanionNodeId;
    }
}
