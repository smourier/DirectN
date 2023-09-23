// generated from <Windows SDK Path>\shared\d3dkmddi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARG_CREATENATIVEFENCE
    {
        public IntPtr hNativeFence;
        public _D3DDDI_NATIVEFENCEMAPPING NativeFenceMapping;
        public ulong CurrentValueGpuVaInCmpAddressSpace;
        public ulong MonitoredValueGpuVaInCmpAddressSpace;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
    }
}
