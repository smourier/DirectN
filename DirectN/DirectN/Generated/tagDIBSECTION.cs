// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagDIBSECTION
    {
        public tagBITMAP dsBm;
        public tagBITMAPINFOHEADER dsBmih;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)] 
        public uint[] dsBitfields;
        public IntPtr dshSection;
        public uint dsOffset;
    }
}
