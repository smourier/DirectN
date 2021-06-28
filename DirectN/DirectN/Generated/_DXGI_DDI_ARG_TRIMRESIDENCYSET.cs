// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\dxgiddi.h(533,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGI_DDI_ARG_TRIMRESIDENCYSET
    {
        public ulong hDevice;
        public int TrimFlags;
        public ulong NumBytesToTrim;
    }
}
