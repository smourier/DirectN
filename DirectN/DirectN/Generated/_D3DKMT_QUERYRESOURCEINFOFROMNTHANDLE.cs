// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1442,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYRESOURCEINFOFROMNTHANDLE
    {
        public uint hDevice;
        public IntPtr hNtHandle;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
        public uint TotalPrivateDriverDataSize;
        public uint ResourcePrivateDriverDataSize;
        public uint NumAllocations;
    }
}
