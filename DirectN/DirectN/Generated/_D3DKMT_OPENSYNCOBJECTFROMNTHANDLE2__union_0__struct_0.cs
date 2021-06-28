// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1411,9)
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
