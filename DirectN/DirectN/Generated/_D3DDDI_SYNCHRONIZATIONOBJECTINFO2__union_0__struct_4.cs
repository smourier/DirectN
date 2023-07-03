// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dukmdt.h(1841,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_4
    {
        public ulong InitialFenceValue;
        public IntPtr FenceValueCPUVirtualAddress;
        public ulong FenceValueGPUVirtualAddress;
        public uint EngineAffinity;
        public uint Padding;
    }
}
