// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\strmif.h(18515,9)
using System;
using System.Runtime.InteropServices;
using LPDIRECTDRAWSURFACE7 = DirectN.IDirectDrawSurface7;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagVMRPRESENTATIONINFO
    {
        public uint dwFlags;
        public IntPtr lpSurf;
        public long rtStart;
        public long rtEnd;
        public tagSIZE szAspectRatio;
        public tagRECT rcSrc;
        public tagRECT rcDst;
        public uint dwTypeSpecificFlags;
        public uint dwInterlaceFlags;
    }
}
