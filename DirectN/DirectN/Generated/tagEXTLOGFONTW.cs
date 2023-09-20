// generated from <Windows SDK Path>\um\wingdi.h
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public partial struct tagEXTLOGFONTW
    {
        public tagLOGFONTW elfLogFont;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)] 
        public string elfFullName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)] 
        public string elfStyle;
        public uint elfVersion;
        public uint elfStyleSize;
        public uint elfMatch;
        public uint elfReserved;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)] 
        public byte[] elfVendorId;
        public uint elfCulture;
        public tagPANOSE elfPanose;
    }
}
