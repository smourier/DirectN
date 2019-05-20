// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dxmini.h(30,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MDL
    {
        public IntPtr MdlNext;
        public short MdlSize;
        public short MdlFlags;
        public IntPtr Process;
        public IntPtr lpMappedSystemVa;
        public IntPtr lpStartVa;
        public uint ByteCount;
        public uint ByteOffset;
    }
}
