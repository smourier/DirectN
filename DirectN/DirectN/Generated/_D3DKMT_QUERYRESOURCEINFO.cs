// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1455,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYRESOURCEINFO
    {
        public uint hDevice;
        public uint hGlobalShare;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
        public uint TotalPrivateDriverDataSize;
        public uint ResourcePrivateDriverDataSize;
        public uint NumAllocations;
    }
}
