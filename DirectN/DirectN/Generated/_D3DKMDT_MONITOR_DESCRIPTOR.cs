// generated from <Windows SDK Path>\shared\d3dkmdt.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMDT_MONITOR_DESCRIPTOR
    {
        public uint Id;
        public _D3DKMDT_MONITOR_DESCRIPTOR_TYPE Type;
        public IntPtr DataSize;
        public IntPtr pData;
        public _D3DKMDT_MONITOR_CAPABILITIES_ORIGIN Origin;
    }
}
