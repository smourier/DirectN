// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
