// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dukmdt.h(1760,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDDI_SYNCHRONIZATIONOBJECTINFO2__union_0__struct_5
    {
        public uint hAdapter;
        public uint VidPnTargetId;
        public ulong Time;
        public IntPtr FenceValueCPUVirtualAddress;
        public ulong FenceValueGPUVirtualAddress;
        public uint EngineAffinity;
    }
}
