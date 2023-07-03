// c:\program files (x86)\windows kits\10\include\10.0.22621.0\shared\d3dkmthk.h(5422,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DKMT_QUERYPROTECTEDSESSIONINFOFROMNTHANDLE
    {
        public IntPtr hNtHandle;
        public IntPtr pPrivateDriverData;
        public uint PrivateDriverDataSize;
        public IntPtr pPrivateRuntimeData;
        public uint PrivateRuntimeDataSize;
    }
}
