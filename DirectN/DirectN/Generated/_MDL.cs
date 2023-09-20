// generated from <Windows SDK Path>\um\dxmini.h
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
