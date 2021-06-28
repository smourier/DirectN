// c:\program files (x86)\windows kits\10\include\10.0.19041.0\um\mfobjects.h(2849,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFVideoSurfaceInfo
    {
        public uint Format;
        public uint PaletteEntries;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public _MFPaletteEntry[] Palette;
    }
}
