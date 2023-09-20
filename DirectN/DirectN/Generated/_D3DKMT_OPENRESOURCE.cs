// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OPENRESOURCE
    {
        public uint hDevice;
        public uint hGlobalShare;
        public uint NumAllocations;
        public _D3DKMT_OPENRESOURCE__union_0 __union_3;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
        public IntPtr pResourcePrivateDriverData;
        public uint ResourcePrivateDriverDataSize;
        public IntPtr pTotalPrivateDriverDataBuffer;
        public uint TotalPrivateDriverDataBufferSize;
        public uint hResource;
    }
}
