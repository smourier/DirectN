// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(960,9)
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
