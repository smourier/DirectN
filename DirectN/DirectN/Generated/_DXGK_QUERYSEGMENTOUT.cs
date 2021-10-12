// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmddi.h(2514,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_QUERYSEGMENTOUT
    {
        public uint NbSegment;
        public IntPtr pSegmentDescriptor;
        public uint PagingBufferSegmentId;
        public uint PagingBufferSize;
        public uint PagingBufferPrivateDataSize;
    }
}
