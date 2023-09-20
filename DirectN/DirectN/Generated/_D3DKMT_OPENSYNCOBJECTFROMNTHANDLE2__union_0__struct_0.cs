// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OPENSYNCOBJECTFROMNTHANDLE2__union_0__struct_0
    {
        public IntPtr FenceValueCPUVirtualAddress;
        public ulong FenceValueGPUVirtualAddress;
        public uint EngineAffinity;
    }
}
