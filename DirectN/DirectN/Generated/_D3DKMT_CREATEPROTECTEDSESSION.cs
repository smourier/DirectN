// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\d3dkmthk.h(5125,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_CREATEPROTECTEDSESSION
    {
        public uint hDevice;
        public uint hSyncObject;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
        public uint hHandle;
    }
}
