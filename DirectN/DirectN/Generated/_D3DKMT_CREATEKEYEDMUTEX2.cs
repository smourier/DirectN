// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(3452,9)
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
