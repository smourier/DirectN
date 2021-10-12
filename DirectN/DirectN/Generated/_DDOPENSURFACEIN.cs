// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddkmapi.h(105,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPENSURFACEIN
    {
        public IntPtr hDirectDraw;
        public IntPtr dwSurfaceHandle;
        public IntPtr pfnSurfaceClose;
        public IntPtr pContext;
    }
}
