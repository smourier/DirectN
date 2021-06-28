// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\d3dcaps.h(549,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DExecuteBufferDesc
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dwCaps;
        public uint dwBufferSize;
        public IntPtr lpData;
    }
}
