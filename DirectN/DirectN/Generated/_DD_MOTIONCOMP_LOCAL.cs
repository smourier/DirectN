// generated from <Windows SDK Path>\um\ddrawint.h
using System;
using System.Runtime.InteropServices;
using PDD_DIRECTDRAW_LOCAL = DirectN._DD_DIRECTDRAW_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_MOTIONCOMP_LOCAL
    {
        public IntPtr lpDD;
        public Guid guid;
        public uint dwUncompWidth;
        public uint dwUncompHeight;
        public _DDPIXELFORMAT ddUncompPixelFormat;
        public uint dwDriverReserved1;
        public uint dwDriverReserved2;
        public uint dwDriverReserved3;
        public IntPtr lpDriverReserved1;
        public IntPtr lpDriverReserved2;
        public IntPtr lpDriverReserved3;
    }
}
