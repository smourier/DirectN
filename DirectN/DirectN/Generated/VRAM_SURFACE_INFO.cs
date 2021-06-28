// c:\program files (x86)\windows kits\10\include\10.0.19041.0\shared\ksmedia.h(4968,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct VRAM_SURFACE_INFO
    {
        public IntPtr hSurface;
        public long VramPhysicalAddress;
        public uint cbCaptured;
        public uint dwWidth;
        public uint dwHeight;
        public uint dwLinearSize;
        public int lPitch;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)] 
        public ulong[] ullReserved;
    }
}
