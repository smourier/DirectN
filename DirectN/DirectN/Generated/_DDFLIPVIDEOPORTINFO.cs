// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxmini.h(232,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDFLIPVIDEOPORTINFO
    {
        public IntPtr lpVideoPortData;
        public IntPtr lpCurrentSurface;
        public IntPtr lpTargetSurface;
        public uint dwFlipVPFlags;
    }
}
