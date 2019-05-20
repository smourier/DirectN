// c:\program files (x86)\windows kits\10\include\10.0.18362.0\shared\d3dkmddi.h(1107,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGKARGCB_GETHANDLEDATA
    {
        public uint hObject;
        public _DXGK_HANDLE_TYPE Type;
        public _DXGKCB_GETHANDLEDATAFLAGS Flags;
    }
}
