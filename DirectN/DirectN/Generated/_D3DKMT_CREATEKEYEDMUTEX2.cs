// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEKEYEDMUTEX2
    {
        public ulong InitialValue;
        public uint hSharedHandle;
        public uint hKeyedMutex;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
        public _D3DKMT_CREATEKEYEDMUTEX2_FLAGS Flags;
    }
}
