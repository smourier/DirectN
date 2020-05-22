// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1317,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEALLOCATION
    {
        public uint hDevice;
        public uint hResource;
        public uint hGlobalShare;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
        public _D3DKMT_CREATEALLOCATION__union_0 __union_5;
        public uint PrivateDriverDataSize;
        public uint NumAllocations;
        public _D3DKMT_CREATEALLOCATION__union_1 __union_8;
        public _D3DKMT_CREATEALLOCATIONFLAGS Flags;
        public IntPtr hPrivateRuntimeResourceHandle;
    }
}
