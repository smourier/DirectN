// c:\program files (x86)\windows kits\10\include\10.0.18362.0\um\dwrite.h(3088,1)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct DWRITE_GLYPH_RUN_DESCRIPTION
    {
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char localeName;
        [MarshalAs(UnmanagedType.LPWStr)] 
        public char @string;
        public uint stringLength;
        public IntPtr clusterMap;
        public uint textPosition;
    }
}
