// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dumddi.h(2509,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVADDI_QUERYEXTENSIONCAPSINPUT
    {
        public IntPtr pGuid;
        public uint CapType;
        public IntPtr pPrivate;
    }
}
