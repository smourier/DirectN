// generated from <Windows SDK Path>\shared\d3dkmddi.h
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
