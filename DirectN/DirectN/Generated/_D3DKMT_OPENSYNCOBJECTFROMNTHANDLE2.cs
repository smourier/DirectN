// generated from <Windows SDK Path>\shared\d3dkmthk.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_OPENSYNCOBJECTFROMNTHANDLE2
    {
        public IntPtr hNtHandle;
        public uint hDevice;
        public _D3DDDI_SYNCHRONIZATIONOBJECT_FLAGS Flags;
        public uint hSyncObject;
        public _D3DKMT_OPENSYNCOBJECTFROMNTHANDLE2__union_0 __union_4;
    }
}
