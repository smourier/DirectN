// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OPENRESOURCEFROMNTHANDLE
    {
        public uint hDevice;
        public IntPtr hNtHandle;
        public uint NumAllocations;
        public IntPtr pOpenAllocationInfo2;
        public uint PrivateRuntimeDataSize;
        public IntPtr pPrivateRuntimeData;
        public uint ResourcePrivateDriverDataSize;
        public IntPtr pResourcePrivateDriverData;
        public uint TotalPrivateDriverDataBufferSize;
        public IntPtr pTotalPrivateDriverDataBuffer;
        public uint hResource;
        public uint hKeyedMutex;
        public IntPtr pKeyedMutexPrivateRuntimeData;
        public uint KeyedMutexPrivateRuntimeDataSize;
        public uint hSyncObject;
    }
}
