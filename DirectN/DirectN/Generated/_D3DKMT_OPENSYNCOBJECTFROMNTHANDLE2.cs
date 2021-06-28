// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\d3dkmthk.h(1401,9)
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
