// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_ACQUIREKEYEDMUTEX2
    {
        public uint hKeyedMutex;
        public ulong Key;
        public IntPtr pTimeout;
        public ulong FenceValue;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
    }
}
