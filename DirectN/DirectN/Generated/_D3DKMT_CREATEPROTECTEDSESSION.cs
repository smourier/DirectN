// generated from <Windows SDK Path>\shared\d3dkmthk.h
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
