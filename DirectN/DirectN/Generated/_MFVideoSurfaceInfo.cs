// generated from <Windows SDK Path>\um\mfobjects.h
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
