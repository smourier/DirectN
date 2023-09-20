// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_VIRTUALGPUSURFACEDATA
    {
        public ulong Size;
        public uint Alignment;
        public uint DriverSegmentId;
        public uint PrivateDriverData;
    }
}
