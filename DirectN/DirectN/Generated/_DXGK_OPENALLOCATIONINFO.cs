// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_OPENALLOCATIONINFO
    {
        public uint hAllocation;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr hDeviceSpecificAllocation;
    }
}
