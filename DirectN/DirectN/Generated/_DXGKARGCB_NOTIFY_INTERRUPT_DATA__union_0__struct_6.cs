// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_NOTIFY_INTERRUPT_DATA__union_0__struct_6
    {
        public uint VidPnTargetId;
        public DXGK_MIRACAST_CHUNK_INFO ChunkInfo;
        public IntPtr pPrivateDriverData;
        public uint PrivateDataDriverSize;
        public int Status;
    }
}
