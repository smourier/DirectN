// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(4945,9)
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
