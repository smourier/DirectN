// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxva9typ.h(226,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVABufferInfo
    {
        public IntPtr pCompSurface;
        public uint DataOffset;
        public uint DataSize;
    }
}
