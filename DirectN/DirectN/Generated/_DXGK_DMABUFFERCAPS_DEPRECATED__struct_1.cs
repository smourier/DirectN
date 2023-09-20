// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_DMABUFFERCAPS_DEPRECATED__struct_1
    {
        public uint Size;
        public uint PrivateDriverDataSize;
        public uint SegmentId;
        public uint Reserved1;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public uint[] Reserved;
    }
}
